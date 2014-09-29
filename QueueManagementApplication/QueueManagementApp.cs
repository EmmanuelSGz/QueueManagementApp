using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueManagementApplication
{
    public partial class QueueManagementApp : Form
    {
        public QueueManagementApp()
        {
            InitializeComponent();
        }

        CustomerInfo customer=new CustomerInfo();

        Queue<CustomerInfo> customerInfos=new Queue<CustomerInfo>();
        ListViewItem cuListViewItem = new ListViewItem("Null");

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            customer.name = enqueueNameTextBox.Text;
            customer.complain = enqueueComplainTextBox.Text;

            customerInfos.Enqueue(customer);

            MessageBox.Show("data saved successfully");

            ListViewItem cuListViewItem=new ListViewItem("Null");
            cuListViewItem.SubItems.Add(customer.name);

            cuListViewItem.SubItems.Add(customer.complain);

            queueListView.Items.Add(cuListViewItem);

 

            enqueueNameTextBox.Text="";
            enqueueComplainTextBox.Text = "";
        }

       private void dequeueButton_Click(object sender, EventArgs e)
      {
           
           //CustomerInfo a=CustomerInfo customerInfos.Dequeue();
           //MessageBox.Show("",customerInfos.Dequeue());
           //serialNoTextBox.Text = Convert.ToString(customer.serialNo);
              //dequeueNameTextBox.Text = customer.name;
               //dequeueComplainTextBox.Text = customer.complain;
          //customerInfos.Dequeue();
               //serialNoTextBox.Text = Convert.ToString(customer.serialNo);
               //dequeueNameTextBox.Text = customer.name;
               //dequeueComplainTextBox.Text = customer.complain;
           //cuListViewItem.SubItems.Clear(); 
           //cuListViewItem.SubItems.Clear();
           string msg = "";
           foreach (CustomerInfo aInfo in customerInfos)
           {
  serialNoTextBox.Text = Convert.ToString(customer.serialNo);
              dequeueNameTextBox.Text = customer.name;
               dequeueComplainTextBox.Text = customer.complain;           
           }

           customerInfos.Dequeue();

cuListViewItem.SubItems.Clear();

           //MessageBox.Show(msg);

      }

    }
}
