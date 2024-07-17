using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.IO;

namespace testing_project
{
    public partial class StoreForm : Form
    {
        private decimal wallet;
        private List<Itemstore> items;
        private FlowLayoutPanel flowLayoutPanel;
        private Label walletLabel;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox imagePathTextBox;
        private Button addButton;

        public StoreForm()
        {
            InitializeComponent();
            InitializeCustomComponents();

            wallet = 100; // Initialize wallet with a default value
            items = new List<Itemstore>();
            LoadItems();
            UpdateWalletLabel();

            // Set the background image for the form
            var fileInfo = new FileInfo(@"..\..\..\pics\background.jpg");
            MessageBox.Show($"File path: {fileInfo.FullName}");
            //string imagePath = Path.Combine(fileInfo.ToString()); // Adjust path
            this.BackgroundImage = Image.FromFile(fileInfo.FullName); // Adjust the path
            this.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fill the form

            // Set up the scrollable panel for items
            var scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            // Set up the FlowLayoutPanel properties
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoScroll = true;

            // Add the FlowLayoutPanel to the scrollablePanel
            scrollablePanel.Controls.Add(flowLayoutPanel);

            // Add the scrollablePanel to the form
            this.Controls.Add(scrollablePanel);

            // Optionally, adjust item size on form resize
            this.Resize += (s, e) => AdjustItemSize();
        }

        private void AdjustItemSize()
        {
            int panelWidth = flowLayoutPanel.ClientSize.Width;
            int minItemWidth = 100; // Minimum width for an item
            int itemMargin = 10; // Adjust this value to control the spacing between items
            int maxItemsPerRow = Math.Max(1, (panelWidth + itemMargin) / (minItemWidth + itemMargin));
            int itemWidth = (panelWidth - (maxItemsPerRow - 1) * itemMargin) / maxItemsPerRow;

            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is Panel itemPanel)
                {
                    itemPanel.Width = itemWidth;
                    itemPanel.Height = 130; // Set a fixed height for each item panel, or calculate dynamically if needed
                }
            }

            flowLayoutPanel.PerformLayout(); // Force the FlowLayoutPanel to re-arrange its contents
        }
        private void InitializeCustomComponents()
        {
            this.flowLayoutPanel = new FlowLayoutPanel
            {
                Location = new System.Drawing.Point(12, 12),
                Name = "flowLayoutPanel1",
                Size = new System.Drawing.Size(760, 400),
                AutoScroll = true // Enable scrolling if needed
            };
            this.Controls.Add(this.flowLayoutPanel);

            this.walletLabel = new Label
            {
                Location = new System.Drawing.Point(12, 12), // Move to top-left corner
                Name = "walletLabel",
                Size = new System.Drawing.Size(100, 23),
                Text = "Wallet: $0.00"
            };
            this.Controls.Add(this.walletLabel);

            // Name TextBox
            //this.nameTextBox = new TextBox
            //{
            //    Location = new System.Drawing.Point(12, 450),
            //    Name = "nameTextBox",
            //    Size = new System.Drawing.Size(200, 23),
            //    PlaceholderText = "Item Name"
            //};
            //this.Controls.Add(this.nameTextBox);

            //// Price TextBox
            //this.priceTextBox = new TextBox
            //{
            //    Location = new System.Drawing.Point(12, 480),
            //    Name = "priceTextBox",
            //    Size = new System.Drawing.Size(200, 23),
            //    PlaceholderText = "Item Price"
            //};
            //this.Controls.Add(this.priceTextBox);

            //// Image Path TextBox
            //this.imagePathTextBox = new TextBox
            //{
            //    Location = new System.Drawing.Point(12, 510),
            //    Name = "imagePathTextBox",
            //    Size = new System.Drawing.Size(200, 23),
            //    PlaceholderText = "Image Path"
            //};
            //this.Controls.Add(this.imagePathTextBox);

            //// Add Button
            //this.addButton = new Button
            //{
            //    Location = new System.Drawing.Point(12, 540),
            //    Name = "addButton",
            //    Size = new System.Drawing.Size(75, 23),
            //    Text = "Add Item"
            //};
            //this.addButton.Click += new EventHandler(this.AddButton_Click);
            //this.Controls.Add(this.addButton);
            //// Debug message to ensure button is added
            //Console.WriteLine("Add Button Initialized");
            //MessageBox.Show($"Add Button Initialized");
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (!decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Invalid price");
                return;
            }
            string imagePath = imagePathTextBox.Text;

            var newItem = new Itemstore(name, price, imagePath);
            items.Add(newItem);
            AddItemToUI(newItem);
        }
        private void AddItemToUI(Itemstore item)
        {
            var panel = new Panel
            {
                Width = 200,
                Height = 180, // Increased height to accommodate all elements
                Margin = new Padding(5)
            };

            var pictureBox = new PictureBox
            {
                ImageLocation = item.ImagePath,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 80,
                Height = 80,
                Top = 5,
                Left = (panel.Width - 80) / 2
            };

            var nameLabel = new Label
            {
                Text = item.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = panel.Width,
                Height = 25,
                Top = pictureBox.Bottom + 5,
                Left = 0
            };

            var priceLabel = new Label
            {
                Text = $"${item.Price}",
                TextAlign = ContentAlignment.MiddleCenter,
                Width = panel.Width,
                Height = 25,
                Top = nameLabel.Bottom + 5,
                Left = 0
            };

            var buyButton = new Button
            {
                Text = "Buy",
                Width = 80,
                Height = 25,
                Top = priceLabel.Bottom + 5,
                Left = (panel.Width - 80) / 2
            };

            buyButton.Click += (sender, e) => BuyItem(item);

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(buyButton);

            flowLayoutPanel.Controls.Add(panel);
        }
        private void LoadItems()
        {
            try
            {
                var fileInfo = new FileInfo(@"../../../storeitems.xlsx");

                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet;

                    // Check if the file exists and load the first worksheet
                    if (fileInfo.Exists)
                    {
                        //MessageBox.Show($"File path: {fileInfo.FullName}");
                        //package.Load(fileInfo); // Load the existing file
                        worksheet = package.Workbook.Worksheets["items"]; // Access the first worksheet
                    }
                    else
                    {
                        // Create a new worksheet if the file does not exist
                        worksheet = package.Workbook.Worksheets.Add("items");
                    }

                    // Find the last used row
                    int lastRow = worksheet.Dimension?.End.Row ?? 0;
                    for (int i = 1; i <= lastRow; i++) // Start from 1
                    {
                        var name = worksheet.Cells[i, 1].Value;
                        var cellValue = worksheet.Cells[i, 2].Value;
                        var path = worksheet.Cells[i, 3].Value;
                        decimal price;
                        //global::testing_project.Properties.Resources.boy_beg

                        if (cellValue != null && decimal.TryParse(cellValue.ToString(), out price))
                        {

                            string imagePath = Path.Combine(Application.StartupPath, @"..\..\..\"+path.ToString());
                            Itemstore item = new Itemstore(name?.ToString(), price, imagePath); // Use null-conditional operator
                            items.Add(item);
                            //MessageBox.Show(" ");
                        }
                        else
                        {
                            // Handle the case where the conversion fails
                            MessageBox.Show($"Row {i}: Value is not a valid decimal.");
                        }
                    }

                    // If you modified the worksheet, save changes
                    // package.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}");
            }
            //MessageBox.Show($"File path: {fileInfo.FullName}");
            foreach (var item in items)
            {
                AddItemToUI(item);
            }
        }
        private void BuyItem(Itemstore item)
        {
            if (wallet >= item.Price)
            {
                wallet -= item.Price;
                UpdateWalletLabel();
                Add_To_excel(item);
                MessageBox.Show($"You bought {item.Name}!");
            }
            else
            {
                //user doesn't have enough money
                MessageBox.Show("אין מספיק כסף!!");
            }
        }
        private void UpdateWalletLabel()
        {
            walletLabel.Text = $"Wallet: ${wallet:F2}";
        }
        private void Add_To_excel(Itemstore item)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                //MessageBox.Show("in the func");
                var fileInfo = new FileInfo(@"../../../storeitems.xlsx");

                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet;

                    // Check if the file exists and load the first worksheet
                    if (fileInfo.Exists)
                    {
                        //MessageBox.Show($"File path: {fileInfo.FullName}");
                        //package = new ExcelPackage(fileInfo);
                        worksheet = package.Workbook.Worksheets[0]; // Access the first worksheet
                    }
                    else
                    {
                        // Create a new worksheet if the file does not exist
                        worksheet = package.Workbook.Worksheets.Add("store");
                    }

                    // Find the last used row
                    int lastRow = worksheet.Dimension?.End.Row ?? 0;
                    worksheet.Cells[lastRow + 1, 1].Value = item.Name;
                    worksheet.Cells[lastRow + 1, 2].Value = item.Price;
                    worksheet.Cells[lastRow + 1, 3].Value = DateTime.Now.ToString();

                    // Save the changes
                    package.Save();
                }

                //MessageBox.Show("Data saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}");
            }
        }

    }
}
