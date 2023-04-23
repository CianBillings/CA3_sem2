using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_sem2
{
    internal class Ship
    {

        public class Passengerinfo
        {
            private string _lastname;
            private string _firstname;
            private string _age;
            private string _sex;
            private string _occupation;
            private string _nativeCountry;
            private string _destination;
            private string _embarkationPort;
            private string _manifestId;
            private string _arrivalDate;

            public string Lastname
            { get { return _lastname; } set { _lastname = value; } }
            public string FirstName
            { get { return _firstname; } set { _firstname = value; } }
            public string Age
            { get { return _age; } set { _age = value; } }
            public string Sex
            { get { return _sex; } set { _sex = value; } }
            public string Occupation
            { get { return _occupation; } set { _occupation = value; } }
            public string NativeCountry
            { get { return _nativeCountry; } set { _nativeCountry = value; } }
            public string Destination
            { get { return _destination; } set { _destination = value; } }
            public string EmbarkationPort
            { get { return _embarkationPort; } set { _embarkationPort = value; } }
            public string ManifestId
            { get { return _manifestId; } set { _manifestId = value; } }
            public string ArrivalDate
            { get { return _arrivalDate; } set { _arrivalDate = value; } }

            public Passengerinfo(string lastname, string firstname, string age, string sex, string occupation, string nativeCountry, string destination, string embarkationPort, string manifestId, string arrivalDate)
            {
                _lastname = lastname;
                _firstname = firstname;
                _age = age;
                _sex = sex;
                _occupation = occupation;
                _nativeCountry = nativeCountry;
                _destination = destination;
                _embarkationPort = embarkationPort;
                _manifestId = manifestId;
                _arrivalDate= arrivalDate;
            }
        }
    }
}
