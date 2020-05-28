using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.NativeMdi;
using DevExpress.XtraEditors;

namespace DocumentManager_NativeMDI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int childCount = 0;
        private void Form1_Load(object sender, EventArgs e) {
            CreateDocumentManager();
            for(int i = 0; i < 3; i++) {
                AddChild();
            }
        }
        void CreateDocumentManager() {
            DocumentManager dm = new DocumentManager(components);
            dm.MdiParent = this;
            dm.View = new NativeMdiView();
        }
        void AddChild() {
            Form childForm = null;
            childForm = new Form();
            childForm.Text = "Child Form " + (++childCount);

            SimpleButton btn = new SimpleButton();
            btn.Text = "Button " + childCount;
            btn.Parent = childForm;

            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}