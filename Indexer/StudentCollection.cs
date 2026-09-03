namespace Entity ; 

class StudentCollection
{
    private List<Student> students = new List<Student>()
    {
        new Student{Id = 1, Name = "Sumit"},
        new Student {Id = 2 ,Name = "shivam"},
        new Student {Id = 3 ,Name = "pari"},
        new Student {Id = 4 ,Name = "aadi"}
    };

    public Student this [int index]
    {   
        get
        {
            return students[index];
        }

        set
        {
            students[index]= value ;
        }
    } 

}