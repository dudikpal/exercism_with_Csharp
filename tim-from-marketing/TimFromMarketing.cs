using System;
using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        (string eId, string eName, string eDepartment) badge = new();
        if (department == null)
        {
            badge.eDepartment = "OWNER";
        } else
        {
            badge.eDepartment = department.ToUpper();
        }
        if (id != null)
        {
            badge.eId = "[" + id + "] ";
        }
        badge.eName = name;
        StringBuilder sb = new StringBuilder();
        sb.Append(badge.eId)
            .Append(badge.eName)
            .Append(" - ")
            .Append(badge.eDepartment);

        return sb.ToString();
    }
}
