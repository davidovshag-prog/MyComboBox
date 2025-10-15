using System.Security.Cryptography.X509Certificates;

namespace MyComboBox;

public class RolesNames
{
    private int _id;
    private string _name;

    public RolesNames()
    {
        this._id = 0;
        this._name = String.Empty;
    }
    public RolesNames(int id, string name)
    {
        this._id = id;
        this._name = name;
    }
    public override string ToString()
    {
        return $"{_id}: {_name}";
    }
}
