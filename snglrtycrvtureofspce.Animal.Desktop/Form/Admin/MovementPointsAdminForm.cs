﻿using System;
using System.Windows.Forms;

namespace snglrtycrvtureofspce.Animal.Desktop.Form.Admin
{
    public partial class MovementPointsAdminForm : System.Windows.Forms.Form
    {
        public MovementPointsAdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            movementPointsBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                movementPointsBindingSource.RemoveCurrent();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.movementPointsBindingSource.EndEdit();
                this.movementPointsTableAdapter.Update(this.lostAnimalsDesktop_ServiceDataSet.MovementPoints);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void movementPointsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movementPointsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAnimalsDesktop_ServiceDataSet);
        }

        private void MovementPointsAdminForm_Load(object sender, EventArgs e)
        {
            this.locationsTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.Locations);
            this.animalsTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.Animals);
            this.movementPointsTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.MovementPoints);
        }

        private void MovementPointsAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.movementPointsTableAdapter.FillBy(this.lostAnimalsDesktop_ServiceDataSet.MovementPoints);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.movementPointsTableAdapter.FillBy1(this.lostAnimalsDesktop_ServiceDataSet.MovementPoints);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
