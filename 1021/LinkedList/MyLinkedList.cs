using System;
namespace LinkedList
{
    public class MyLinkedList
    {
        public Node head;

        public MyLinkedList()
        {
            head = null;
        }

        public bool AddToEnd(int sNo, string name, string surname, string tName, string tSurname, string lName, int note1, int note2, int avrage)
        {
            try
            {
                Students_System system = new Students_System(sNo, name, surname, tName, tSurname, lName, note1, note2, avrage);
                Node student = new Node(system);

                if (head == null)
                {
                    head = student;
                    student.Next = null;
                    Console.WriteLine("Listeye Oluşturuldu, İlk Öğrenci Eklendi");
                }
                else
                {
                    Node temp = head;

                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }

                    temp.Next = student;
                    Console.WriteLine("Öğrenci Başarıyla Eklendi");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kodunda hata var. Hata mesajı: " + ex.Message);
            }
            return false;
        }

        public void List()
        {
            Node list = head;

            try
            {
                while (list != null)
                {
                    Console.WriteLine($"OkulNumarası: {list.SystemData.SchoolNo}");
                    Console.WriteLine($"Öğrenci Adı: {list.SystemData.StudentName}");
                    Console.WriteLine($"Soyadı: {list.SystemData.StudentSurname}");
                    Console.WriteLine($"Öğretmen Adı: {list.SystemData.TeacherName}");
                    Console.WriteLine($"Öğretmen Soyadı: {list.SystemData.TeacherSurname}");
                    Console.WriteLine($"Dersi: {list.SystemData.LessonName}");
                    Console.WriteLine($"1.Notu: {list.SystemData.Note1}");
                    Console.WriteLine($"2.Notu: {list.SystemData.Note2}");
                    Console.WriteLine($"Not Ortalaması: {list.SystemData.Avrange}");

                    list = list.Next;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kodunda hata var. Hata mesajı: " + ex.Message);
            }

        }

        public bool Delete(int sNo)
        {
            try
            {
                if (head == null)
                    return false;

                if (head.SystemData.SchoolNo == sNo)
                {
                    head = head.Next;
                    return true;
                }

                Node prev = null;
                Node current = head;

                while (current != null)
                {
                    if (current.SystemData.SchoolNo == sNo)
                    {
                        prev.Next = current.Next;
                        return true;
                    }
                    prev = current;
                    current = current.Next;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kodunda hata var. Hata mesajı: " + ex.Message);
            }

            return false;
        }

        public bool Update(int sNo, string name, string surname, string tName, string tSurname, string lName, int note1, int note2, int avrage)
        {
            Node current = head;

            try
            {
                while (current != null)
                {
                    if (current.SystemData.SchoolNo == sNo)
                    {
                        current.SystemData.StudentName = name;
                        current.SystemData.StudentSurname = surname;
                        current.SystemData.TeacherName = tName;
                        current.SystemData.TeacherSurname = tSurname;
                        current.SystemData.LessonName = lName;
                        current.SystemData.Note1 = note1;
                        current.SystemData.Note2 = note2;
                        current.SystemData.Avrange = avrage;
                        return true;
                    }
                    current = current.Next;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kodunda hata var. Hata mesajı: " + ex.Message);
            }

            return false;
        }
    }

}

