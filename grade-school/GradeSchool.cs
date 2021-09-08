using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{

    private Dictionary<string, int> gradeSchool = new Dictionary<string, int>();


    public void Add(string student, int grade)
    {
        gradeSchool.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return gradeSchool
            .OrderBy(s => s.Value)
            .ThenBy(s => s.Key)
            .Select(s => s.Key);
        
    }

    public IEnumerable<string> Grade(int grade)
    {
        return gradeSchool
            .Where(g => g.Value == grade)            
            .OrderBy(s => s.Value)
            .ThenBy(s => s.Key)
            .Select(s => s.Key);

        
    }
}