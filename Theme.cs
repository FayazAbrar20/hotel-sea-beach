using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace hotelseabeach
{
    internal static class Theme
    {
        static readonly Color Sky = Color.FromArgb(178, 224, 247);
        static readonly Color Sand = Color.FromArgb(246, 226, 186);
        static readonly Color Ink = Color.FromArgb(28, 45, 64);
        static readonly Color Ocean = Color.FromArgb(18, 120, 160);
        static readonly Color OceanHover = Color.FromArgb(12, 96, 130);
        static readonly Color Coral = Color.FromArgb(232, 106, 84);
        static readonly Color CoralHover = Color.FromArgb(204, 84, 64);
        static readonly Color Deep = Color.FromArgb(22, 66, 96);
        static readonly Color Foam = Color.FromArgb(236, 246, 252);

        public static void Apply(Form form, string title)
        {
            form.Text = "Hotel Sea Beach – " + title;
            SetDoubleBuffered(form);
            PaintGradient(form);
            form.Resize += (s, e) => PaintGradient(form);
            Style(form.Controls);
        }

        static void PaintGradient(Form form)
        {
            var size = form.ClientSize;
            if (size.Width < 1 || size.Height < 1) return;
            var bmp = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(bmp))
            using (var brush = new LinearGradientBrush(new Rectangle(Point.Empty, size), Sky, Sand, LinearGradientMode.Vertical))
                g.FillRectangle(brush, 0, 0, size.Width, size.Height);
            var old = form.BackgroundImage;
            form.BackgroundImage = bmp;
            form.BackgroundImageLayout = ImageLayout.Stretch;
            if (old != null) old.Dispose();
        }

        static void Style(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                SetFont(c);
                if (c is Button) StyleButton((Button)c);
                else if (c is DataGridView) StyleGrid((DataGridView)c);
                else if (c is TextBox)
                {
                    var t = (TextBox)c;
                    t.BackColor = Color.White;
                    t.ForeColor = Ink;
                    t.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (c is ComboBox)
                {
                    var cb = (ComboBox)c;
                    cb.BackColor = Color.White;
                    cb.ForeColor = Ink;
                    cb.FlatStyle = FlatStyle.Flat;
                }
                else if (c is Label || c is CheckBox || c is RadioButton)
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Ink;
                }
                if (c.HasChildren && !(c is DataGridView)) Style(c.Controls);
            }
        }

        static void StyleButton(Button b)
        {
            var text = (b.Text + " " + b.Name).ToLowerInvariant();
            bool danger = text.Contains("delete") || text.Contains("sign") || text.Contains("deactive") || text.Contains("back");
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = danger ? Coral : Ocean;
            b.FlatAppearance.MouseOverBackColor = danger ? CoralHover : OceanHover;
            b.FlatAppearance.MouseDownBackColor = danger ? CoralHover : OceanHover;
            b.ForeColor = Color.White;
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
        }

        static void StyleGrid(DataGridView d)
        {
            d.EnableHeadersVisualStyles = false;
            d.BorderStyle = BorderStyle.None;
            d.BackgroundColor = Foam;
            d.GridColor = Color.FromArgb(205, 225, 236);
            d.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            d.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            d.ColumnHeadersHeight = 34;
            d.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            d.ColumnHeadersDefaultCellStyle.BackColor = Deep;
            d.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            d.ColumnHeadersDefaultCellStyle.SelectionBackColor = Deep;
            d.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            d.RowHeadersVisible = false;
            d.DefaultCellStyle.BackColor = Color.White;
            d.DefaultCellStyle.ForeColor = Ink;
            d.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            d.DefaultCellStyle.SelectionBackColor = Ocean;
            d.DefaultCellStyle.SelectionForeColor = Color.White;
            d.AlternatingRowsDefaultCellStyle.BackColor = Foam;
            d.RowTemplate.Height = 28;
        }

        static void SetFont(Control c)
        {
            if (c is DataGridView) return;
            var f = c.Font;
            float size = f.FontFamily.Name == "Times New Roman" ? f.Size * 0.85F : f.Size * 0.92F;
            c.Font = new Font("Segoe UI", size, f.Style);
        }

        static void SetDoubleBuffered(Control c)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (prop != null) prop.SetValue(c, true, null);
        }
    }
}
