namespace RESRTfull.Domain
{
    internal class JobExperience
    {
        private Guid _id;
        private Job _currentJob;
        private Job[] _previousJobs;

        public JobExperience(Guid id, Job currentJob, Job[] previousJobs)
        {
            _id = id;
            _currentJob = currentJob;
            _previousJobs = previousJobs;
        }

        public Guid ID
        {
            get 
            { 
                return _id;
            } 
            set
            {
                _id = value; 
            }
        }
        public Job CurrentJob
        {
            get
            {
                return _currentJob;
            }
            set
            { 
                _currentJob = value;

            }
        }
        public Job[] PreviousJobs
        {
            get
            {
                return _previousJobs;
            }
            set
            {
                _previousJobs = value;
            }
        }

    }
}
