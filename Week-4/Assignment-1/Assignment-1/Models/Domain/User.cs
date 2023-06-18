namespace Assignment_1.Models.Domain
{
    // we want to create a model which we will be able to use as a domain model or entity
    // we want to create "users" and perform CRUD operation on "users", so we will create a "users" model
    public class User
    {
        // "Guid" represents a globally unique identifier
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        /* we have our properties defined for the User domain model and this is what we want to persist in the database and then further retrieve the list of users and a single user */
        // we are going to use this domain model inside our "AssignmentDbContext.cs"
    }
}
