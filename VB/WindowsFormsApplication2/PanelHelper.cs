using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication2
{
    public class PanelHelper
    {
        DockManager manager;

        public PanelHelper(DockManager manager)
        {
            this.manager = manager;
            manager.RegisterDockPanel += OnRegisterDockPanel;
        }

        private void OnRegisterDockPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            e.Panel.AllowDrop = true;
            e.Panel.DragOver += OnPanelDragOver;
        }
    
        private void OnPanelDragOver(object sender, DragEventArgs e)
        {
            DockPanel pnl = sender as DockPanel;
            Point pt = pnl.PointToClient(new Point(e.X, e.Y));
            HitInfo info = pnl.GetHitInfo(pt);
            if (info.HitTest == HitTest.Tab)
            {
                e.Effect = DragDropEffects.All;
                info.Tab.Show();
            }
        }

        private void OnUnregisterDockPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            e.Panel.DragOver -= OnPanelDragOver;
        }
    }
}
