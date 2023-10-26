namespace RESRTfull.Domain

{
    public class Documentation
    {
        private Guid _id;
        private DocRussianPassport? _passportRussian;
        private DocForeignPassport? _foreignPassport;
        private DocInternationalPassport? _internationalPassport;
        private Document _snils;
        private Document? _militaryID;
        private Document _TIN;

        public Documentation(Guid id, DocRussianPassport? passportRussian, DocForeignPassport? foreignPassport, 
            DocInternationalPassport? internationalPassport, Document snils, Document? militaryID, Document tIN)
        {
            _id = id;
            _passportRussian = passportRussian;
            _foreignPassport = foreignPassport;
            _internationalPassport = internationalPassport;
            _snils = snils;
            _militaryID = militaryID;
            _TIN = tIN;
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
        public DocRussianPassport? PassportRussian
        {
            get
            {
                return _passportRussian;
            }
            set
            {
                _passportRussian = value;
            }
        }
        public DocForeignPassport? ForeignPassport
        {
            get
            {
                return _foreignPassport;
            }
            set
            {
                _foreignPassport = value;
            }
        }
        public DocInternationalPassport? InternationalPassport
        {
            get
            {
                return _internationalPassport;
            }
            set
            {
                _internationalPassport = value;
            }
        }

        public Document SNILS
        {
            get
            {
                return _snils;
            }
            set
            {
                _snils = value;
            }
        }

        public Document TIN
        {
            get
            {
                return _TIN;
            }
            set
            {
                _TIN = value;
            }
        }

        public Document? MilitaryID
        {
            get
            {
                return _militaryID;
            }
            set
            {
                _militaryID = value;
            }
        }

    }
}
