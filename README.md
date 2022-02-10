# CSharp_GUI_FriendManagement
Using Winform

## 유의사항
1. 삭제시에는 for문을 count 개수부터 시작해서 0까지 i--로 삭제해야한다.
```
for (int i = count - 1; i >= 0; i--)
{
    if (listView1.Items[i].Checked)
    {
        listView1.Items.RemoveAt(i);
        ar.RemoveAt(i);
    }
}
```
2. 공용 Dialog 사용  
C++ MFC와 마찬가지로 Modal 방식과 Modaless 방식이 있다.  
Modal 방식은 대화상자가 끝날 때까지 다른 작업을 못한다.  
반면에 Modaless 방식은 대화상자가 진행중이어도 다른 작업이 가능하다.  

3. Serialize, Deserialize (직렬화, 역직렬화 이용하여 저장 및 불러오기)  
대부분의 파일 저장, 불러오기와 마찬가지로  
맨 앞에 count 값을 먼저 저장하고, 읽을 때도 count 값을 먼저 읽어온다.  
```
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
```
Serailize 활용, 기본 저장 코드 (쓰기)
```
HumanSeri Hong = new HumanSeri("홍길동", 28);

FileStream fs = new FileStream(@"c:\Temp\HongSoap.dat",   // file path
                                FileMode.Create,          // file mode
                                FileAccess.Write);        // file access
SoapFormatter sf = new SoapFormatter();

sf.Serialize(fs, Hong);
fs.Close();
```

DeSerailize 활용, 기본 불러오기 코드 (열기)
```
FileStream fs = new FileStream(@"c:\Temp\HongSeri.dat",   // file path
                               FileMode.Open,             // file mode
                               FileAccess.Read);          // file access
BinaryFormatter bf = new BinaryFormatter();

HumanSeri Hong = (HumanSeri)bf.Deserialize(fs);
fs.Close();
```
