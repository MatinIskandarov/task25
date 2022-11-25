public class Student
{
    private static int count = 0;
    private int _id;
    private string _name;
    private string _surname;
    private string _groupno;

    public int Id { get { return _id; } }

    public string Name { get { return _name; } set { _name = value; } }
    public string Surname { get { return _surname; } set { _surname = value; } }
    public string Groupno { get { return _groupno; } set { _groupNo = value; } }


    public Student(string name, string surname, string groupno)
    {
        bool isTrue = false;
        if (groupno.Length == 5)
        {

            for (int i = 0; i < groupno.Length; i++)
            {

                if (i >= 2)
                {

                    if (!(groupno[i] >= '0' && groupno[i] <= '9'))
                    {

                        isTrue = false;
                        break;
                    }
                }
                else
                {

                    if (!(groupno[i] >= 'A' && groupno[i] <= 'Z'))
                    {

                        isTrue = false;
                        break;
                    }
                }
            }

            isTrue = true;

        }

        if (isTrue)
        {

            Name = name;
            Surname = surname;
            Groupno = groupno;
            count++;
            _id = count;
        }

    }
}