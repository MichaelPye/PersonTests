namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IResettable, IMeasurable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "")
        {
            this.Name = name.Trim();
        }

        public void Count()
        {
            string[] count = Name.Split("");

            foreach (char c in Name)
            {
                if (char.IsLetter(c))
                {
                    Size++;
                }
            }
        }

        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// Method Resettable returns empty string.
        /// </summary>
        public void Resettable()
        {
            this.Name = "";
        }

        /// <summary>
        /// Method Displayable generates message box that shows name.
        /// </summary>
        public void Displayable()
        {
            MessageBox.Show(Name);
        }

        public int CompareTo(Person person)
        {
            if (this.Name == person.Name)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
