using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;

namespace AtmSharp
{
    /// <summary>
    /// Defines the valid account types that can be created by the user. Note that the 
    /// application creates default general accounts as well but the user can only create
    /// accounts designated through the enum values below.
    /// </summary>
    public enum AccountType
    {
    }

    /// <summary>
    /// Defines a bank account its associated attributes and operations.
    /// </summary>
    public class Account
    {
    }
}
