using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwineSyncc
{
    public partial class RegisterPig : UserControl
    {
        private readonly Color AccentColor = Color.FromArgb(88, 72, 60);
        private readonly Color BackgroundColor = Color.FromArgb(221, 223, 222);
        private readonly Font HeaderFont = new Font("Source Sans 3", 24, FontStyle.Bold);
        private readonly Font LabelFont = new Font("Source Sans 3", 14, FontStyle.Bold);
        private readonly Font RadioFont = new Font("Source Sans 3", 9, FontStyle.Bold);

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public RegisterPig()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.BackColor = Color.WhiteSmoke; 

            panel1.BackColor = Color.FromArgb(217, 221, 220); 
            ApplyTheme();
            StyleButtons();
        }

        private void ApplyTheme()
        {
          
            this.BackColor = Color.White;
           
            registerpiglbl.ForeColor = AccentColor;
            registerpiglbl.Font = HeaderFont;
           
            foreach (var label in new[] { tagnumberlbl, birthdatelbl, breedlbl, weightlbl, sexlbl, statuslbl })
            {
                label.ForeColor = AccentColor;
                label.Font = LabelFont;
            }

            foreach (var radio in new[] { maleradiobtn, femaleradiobtn })
            {
                radio.ForeColor = AccentColor;
                radio.Font = RadioFont;
            }
        }
        private void StyleButtons()
        {
            Color brown = AccentColor;
            Color bg = BackgroundColor;
            Font buttonFont = new Font("Source Sans 3", 14, FontStyle.Bold);

            // --- Save Button (filled brown) ---
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.FlatAppearance.BorderSize = 0;
            savebtn.BackColor = brown;
            savebtn.ForeColor = bg;
            savebtn.Font = buttonFont;
            savebtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, savebtn.Width, savebtn.Height, 20, 20));

            // --- Clear Button (white, no border) ---
            clearbtn.FlatStyle = FlatStyle.Flat;
            clearbtn.FlatAppearance.BorderSize = 0;
            clearbtn.BackColor = Color.White;
            clearbtn.ForeColor = brown;
            clearbtn.Font = buttonFont;
            clearbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearbtn.Width, clearbtn.Height, 20, 20));

            // --- Cancel Button (white, no border) ---
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.FlatAppearance.BorderSize = 0;
            cancelbtn.BackColor = Color.White;
            cancelbtn.ForeColor = brown;
            cancelbtn.Font = buttonFont;
            cancelbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelbtn.Width, cancelbtn.Height, 20, 20));

            // --- Hover Effects ---
            savebtn.MouseEnter += (s, e) => savebtn.BackColor = Color.FromArgb(70, 55, 45);
            savebtn.MouseLeave += (s, e) => savebtn.BackColor = brown;

            clearbtn.MouseEnter += (s, e) => clearbtn.BackColor = Color.FromArgb(245, 245, 245);
            clearbtn.MouseLeave += (s, e) => clearbtn.BackColor = Color.White;

            cancelbtn.MouseEnter += (s, e) => cancelbtn.BackColor = Color.FromArgb(245, 245, 245);
            cancelbtn.MouseLeave += (s, e) => cancelbtn.BackColor = Color.White;
        }

        private void RegisterPig_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 20;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(rect.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(rect.Width - borderRadius, rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);
        }

        
    }
}
