
namespace TwitterClone.Domain.Entities
{
    internal class User
    {
//this is fields:
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;

//this is constructor for making unique id (it will run one time,
//so this unique id will generate only one time)
//constructor name(User), and class name(User) will always same.
        public User()
        {
            _id = Guid.NewGuid();
        }

//now we return this "_id",so that user get this id, when inspect.
//must mention the type of "_id"-->Guid, here Id--> is the variable.
//these three are-->"Property"
        public Guid Id { get { return _id; } }
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }

        }

        public string LastName { 
            get { return _lastName; }
            set{ _lastName = value; }
        }
    }
}
