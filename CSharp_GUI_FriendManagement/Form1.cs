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

// 네임 스페이스
namespace CSharp_GUI_FriendManagement
{
    //기본 폼 클라스
    public partial class Form1 : Form
    {
        // 변수 선언
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        // 클래스 선언
        MyFriend myFriend = new MyFriend("",0,"");
        // ArrayList 선언
        List<MyFriend> ar = new List<MyFriend>();

        public Form1()
        {
            // 폼 기본 생성자
            InitializeComponent();
        }

        // 친구 추가 버튼 클릭시 발생 이벤트
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
            // string 배열에 값들을 넣고 한번에 리스트 뷰에 추가
            string[] arString = new string[] { Name,Age.ToString(),Gender};
            var item = new ListViewItem(arString);
            listView1.Items.Add(item);

            // ArrayList에도 값 추가
            MyFriend myFriend = new MyFriend(Name,Age,Gender);
            ar.Add(myFriend);

            //이름,나이,성별 입력칸 초기화
            NameBox.Text = "";
            AgeBox.Text = "";
            R_Men_Btn.Checked = false;
            R_Women_Btn.Checked = false;
        }
        // 친구 삭제 버튼 클릭시 발생 이벤트
        private void RemoveFriend_Btn_Click(object sender, EventArgs e)
        {
            int count = ar.Count;
            // 식제시에 배열은 총 개수에서 --로 삭제해야 한다.
            // 배열은 0부터 시작이기 때문에, 삭제시에는 count -1 부터 시작이다.
            for (int i = count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked)
                {
                    listView1.Items.RemoveAt(i);
                    ar.RemoveAt(i);
                }
            }
        }
        // 메뉴의 열기 버튼 클릭시 발생 이벤트
        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //----- 열기(Load) 공용 Dialog 시작 ------
            var result = openFileDialog1.ShowDialog();
            // OK 버튼 안 누를 시 바로 return
            if (result != DialogResult.OK) return;

            string FileName;
            FileName = openFileDialog1.FileName;
            openFileDialog1.Dispose();
            //----- 열기(Load) 공용 Dialog 끝 ------

            // 객체 직렬화 Binary Formatter 사용 : 읽기
            FileStream fs = new FileStream(FileName,   // file path
                                                FileMode.Open,    // file mode
                                                FileAccess.Read);  // file access
            BinaryFormatter bf = new BinaryFormatter();

            // 파일에 담긴 리스트의 총 개수부터 읽어온다.
            int TotalCount = 0; 
            TotalCount = (int)bf.Deserialize(fs);

            // 리스트의 총 개수를 토대로 for문을 돌려서 모든 데이터 값들을 읽어오고,
            // 다시 ListView와 ArrayList에 추가해준다. 
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
        // 메뉴의 저장 버튼 클릭시 발생 이벤트
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //----- 저장(Save) 공용 Dialog 시작 ------
            var result = saveFileDialog1.ShowDialog();
            // OK 버튼 안 누를 시 바로 return
            if (result != DialogResult.OK) return;

            string FileName;
            FileName = saveFileDialog1.FileName;
            saveFileDialog1.Dispose();
            //----- 저장(Save) 공용 Dialog 끝 ------

            // 객체 직렬화 Binary Formatter 사용 : 쓰기
            FileStream fs = new FileStream(FileName,   // file path
                                                FileMode.Create,    // file mode
                                                FileAccess.Write);  // file access
            BinaryFormatter bf = new BinaryFormatter();

            // ArrayList 담긴 리스트의 총 개수부터 저장한다.
            bf.Serialize(fs, ar.Count);

            // 리스트의 총 개수를 토대로 for문 돌려서 전부 저장
            for (int i = 0; i < ar.Count; i++)
            {
                bf.Serialize(fs, ar[i]);
            }

            // 초기화
            listView1.Items.Clear();
            ar.Clear();
            fs.Close();
            MessageBox.Show("저장이 완료되었습니다.");
        }
        // 메뉴의 끝내기 버튼 클릭시 발생 이벤트
        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 프로그램 종료
            Application.Exit();
        }
    }
    // Serialize 방식 저장을 위한 Class 앞 부분에서 선언
    [Serializable]
    // 이름, 나이, 성별을 관리하는 Class
    class MyFriend
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // MyFriend Class 기본 생성자
        public MyFriend(string _name, int _age, string _gender)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
        }
    }
}
