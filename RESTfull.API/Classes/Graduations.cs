namespace RESRTfull.Domain
{
    public class Graduations
    {
        private Guid _id;
        private Education _schoolSertificate;
        private Education? _diplomaSertificate;
        private Education? _bachelorSertificate;
        private Education? _masterSertificate;
        private Education? _phdSertificate;

        public Graduations( Guid id, Education schoolSertificate, Education? diplomaSertificate, Education? bachelorSertificate, Education? masterSertificate, Education? phdSertificate)
        {
            _id = id;
            _schoolSertificate = schoolSertificate;
            _diplomaSertificate = diplomaSertificate;
            _bachelorSertificate = bachelorSertificate;
            _masterSertificate = masterSertificate;
            _phdSertificate = phdSertificate;
        }
        public Guid Id { 
            get
            { 
                return _id;
            }
        set 
            { 
                _id = value;
            }
        }
        public Education SchoolSertificate
        {
            get
            {
                return _schoolSertificate;
            }
            set
            {
                _schoolSertificate = value;
            }
        }
        public Education? DiplomaSertificate
        {
            get 
            { 
                return _diplomaSertificate;
            }
            set 
            { 
                _diplomaSertificate = value;
            }
        }

        public Education? BachelorSertificate
        {
            get
            {
                return _bachelorSertificate;
            }
            set
            {
                _bachelorSertificate= value;
            }
        }
        public Education? MasterSertificate
        {
            get
            {
                return _masterSertificate;
            }
            set
            {
                _masterSertificate = value;
            }
        }
        public Education? PhDSertificate
        {
            get
            {
                return _phdSertificate;
            }
            set
            {
                _phdSertificate= value;
            }
        }
    }    
}
