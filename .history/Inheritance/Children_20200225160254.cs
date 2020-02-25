using System;
public class Children
{
    private Family fam = new Family();
    private readonly string fatherName = fam.fatherName;
    private readonly string motherName = fam.motherName;
    private readonly string familyName = fam.familyName;
    private string childFName;
    public Children(string name)
    {
        this.childFName = name;
    }

}