using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_GUI_FriendManagement
{
    public partial class Form1 : Form
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        MyFriend myFriend = new MyFriend("",0,"");
        List<MyFriend> ar = new List<MyFriend>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddFriend_Btn_Click(object sender, EventArgs e)
        {
            Name = NameBox.Text;
            Age = Convert.ToInt32(AgeBox.Text);
            if (R_Men_Btn.Checked)
            {
                Gender = "남성";
            }
            else if(R_Women_Btn.Checked)
            {
                Gender = "여성";
            }

            string[] arString = new string[] { Name,Age.ToString(),Gender};
            var item = new ListViewItem(arString);
            listView1.Items.Add(item);

            MyFriend myFriend = new MyFriend(Name,Age,Gender);
            ar.Add(myFriend);
        }

        private void RemoveFriend_Btn_Click(object sender, EventArgs e)
        {
            //int count = listView1.Items.Count;C:\Users\BIT\source\repos\Winform\CSharp_GUI_
            int count = ar.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked)
                {
                    listView1.Items.RemoveAt(i);
                    ar.RemoveAt(i);
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            string FileName;
            FileName = openFileDialog1.FileName;
            openFileDialog1.Dispose();

            // 객체 직렬화 Binary Formatter 사용 : 읽기
            FileStream fs = new FileStream(FileName,   // file path
                                                FileMode.Open,    // file mode
                                                FileAccess.Read);  // file access
            BinaryFormatter bf = new BinaryFormatter();

            int TotalCount = 0; 
            TotalCount = (int)bf.Deserialize(fs);

            for (int i=0; i< TotalCount; i++)
            {
                MyFriend myFriend = (MyFriend)bf.Deserialize(fs);
                Name = myFriend.Name;
                Age = myFriend.Age;
                Gender = myFriend.Gender;

                string[] arString = new string[] { Name, Age.ToString(), Gender };
                var item = new ListViewItem(arString);
                listView1.Items.Add(item);
                ar.Add(myFriend);
            }
            MessageBox.Show("불러오기가 완료되었습니다.");
            fs.Close();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            string FileName;
            FileName = saveFileDialog1.FileName;
            saveFileDialog1.Dispose();

            // 객체 직렬화 Binary Formatter 사용 : 쓰기
            FileStream fs = new FileStream(FileName,   // file path
                                                FileMode.Create,    // file mode
                                                FileAccess.Write);  // file access
            BinaryFormatter bf = new BinaryFormatter();

            // int TotalCount = listView1.Items.Count;
            int TotalCount = ar.Count;

            // 선택해서 저장하고 싶을 때 
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    if (listView1.Items[i].Checked)
            //    {
            //        TotalCount++;
            //    }
            //}

            bf.Serialize(fs,TotalCount);

            for (int i = 0; i < TotalCount; i++)
            {
                //myFriend.Name = listView1.Items[i].Text;
                //myFriend.Age = Convert.ToInt32(listView1.Items[i].SubItems[1].Text);
                //myFriend.Gender = listView1.Items[i].SubItems[2].Text;
                myFriend.Name = ar[i].Name;
                myFriend.Age = ar[i].Age;
                myFriend.Gender = ar[i].Gender;
                bf.Serialize(fs, myFriend);
            }

            // 선택해서 저장하고 싶을 때 
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    if (listView1.Items[i].Checked)
            //    {
            //        myFriend.Name = listView1.Items[i].Text;
            //        myFriend.Age = Convert.ToInt32(listView1.Items[i].SubItems[1].Text);
            //        myFriend.Gender = listView1.Items[i].SubItems[2].Text;
            //        bf.Serialize(fs, myFriend);
            //    }
            //}
            // 초기화
            listView1.Items.Clear();
            ar.Clear();
            fs.Close();
            MessageBox.Show("저장이 완료되었습니다.");


        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    [Serializable]
    class MyFriend
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public MyFriend(string _name, int _age, string _gender)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
        }
    }
}
