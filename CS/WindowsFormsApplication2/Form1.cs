using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textEdit2.AllowDrop = textEdit3.AllowDrop = true;
            textEdit2.DragDrop += OnTextEditDragDrop;
            textEdit3.DragDrop += OnTextEditDragDrop;

            textEdit2.DragOver += OnTextEditDragOver;
            textEdit3.DragOver += OnTextEditDragOver;

            new PanelHelper(dockManager1);
        }

    
    
        private void OnTextEditMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ((Math.Abs(e.X - p.X) > SystemInformation.DragSize.Width)
                || (Math.Abs(e.Y - p.Y) > SystemInformation.DragSize.Height)))
            {
                TextEdit textEdit = sender as TextEdit;
                textEdit.DoDragDrop(textEdit.Text, DragDropEffects.All);
            }
        }


        Point p;
        private void OnTextEditMouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }

        void OnTextEditDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
        }


        void OnTextEditDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string text = e.Data.GetData(typeof(string)).ToString();
                TextEdit textEdit = sender as TextEdit;
                textEdit.EditValue = text;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            textEdit2.DragDrop -= OnTextEditDragDrop;
            textEdit3.DragDrop -= OnTextEditDragDrop;

            textEdit2.DragOver -= OnTextEditDragOver;
            textEdit3.DragOver -= OnTextEditDragOver;
        }
    }
}