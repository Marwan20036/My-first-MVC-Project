namespace MarwanWeb.Models
{
    using System;
    
    /// <summary>
    /// Represents a view model for the contact form
    /// </summary>
    public class ContactViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public void Validate()
        {
            if (String.IsNullOrWhiteSpace(this.Name))
            {
                throw new ArgumentException
                (
                    "The name is required."
                );
            }

            if (String.IsNullOrWhiteSpace(this.Email))
            {
                throw new ArgumentException
                (
                    "The email address is required."
                );
            }
        }
    }
}
