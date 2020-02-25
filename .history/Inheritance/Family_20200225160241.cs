using System;
public class Family
{
    private string fatherName;
    private string motherName;
    private string familyName;
    private int numOfChildren = 0;

    public Family(string mother, string father, string family)
    {
        this.motherName = mother;
        this.fatherName = father;
        this.familyName = family;
    }
    public haveBaby(string name)
    {
        this.numOfChildren++;
        Children child = new Children(name);
    }


}