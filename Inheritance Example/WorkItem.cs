using System;

namespace IV.Inheritance_Example
{
    class WorkItem
    {   // Static field currentID stores the job ID of the last WorkItem that
        // has been created.
        private static int currentID;

        // Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan JobLength { get; set; }
        // Default constructor. If a derived class does not invoke a base-
        // class constructor explicitly, the default constructor is called
        // implicitly.
        public WorkItem()
        {
            ID = 0;
            Title = "Default Title";
            Description = "Default Description";
            JobLength = new TimeSpan();
        }
        // Instance constructor that has three parameters.
        public WorkItem(string title, string description, TimeSpan jobLength)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.Description = description;
            this.JobLength = jobLength;
        }
        // Static constructor to initialize the static member, currentID. This
        // constructor is called one time, automatically, before any instance
        // of WorkItem or ChangeRequest is created, or currentID is referenced.
        static WorkItem()
        {
            currentID = 0;
        }

        protected int GetNextId()
        {
            // currentID is a static field. It is incremented each time a new
            // instance of WorkItem is created.
            return ++currentID;
        }

        // Method Update enables you to update the title and job length of an
        // existing WorkItem object.
        public void Update(string title, TimeSpan jobTimeSpan)
        {
            this.Title = title;
            this.JobLength = jobTimeSpan;
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object.
        public override string ToString()
        {
            return $"{this.ID} - {this.Title}";
        }
    }

    class ChangeRequest : WorkItem
    {
        protected int OriginalItemID { get; set; }

        public ChangeRequest()
        {

        }

        public ChangeRequest(string title, string description, TimeSpan jobLength, int originalId)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.Description = description;
            this.JobLength = jobLength;
            this.OriginalItemID = originalId;
        }
    }
}
