using RealEstateCRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class Comment : AuditableEntity<int>
    {
        public int Id { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public string Content { get; private set; }
        public Guid PropertyId { get; private set; }
        public Property Property { get; private set; }
        public int? Rating { get; private set; }
        private Comment() { }
        private Comment(Guid userId, User user, string content, Guid propertyId, Property property) : this()
        {
            UserId = userId;
            User = user;
            Content = content;
            PropertyId = propertyId;
            Property = property;
        }
        public static Comment Create(Guid userId, User user, string content, Guid propertyId, Property property)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("User not found", nameof(userId));
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User is required");
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content is required", nameof(content));
            if (propertyId == Guid.Empty)
                throw new ArgumentException("Property not found", nameof(propertyId));
            if (property == null)
                throw new ArgumentNullException(nameof(property), "Property is required");

            return new Comment(userId, user, content, propertyId, property);

        }
        public void Update(string content, int? rating)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Content is required", nameof(content));
            Content = content;

            if (rating.HasValue && (rating < 1 || rating > 5))
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 1 and 5");
                Rating = rating;            
        }
        public void Delete()
        {
            base.Delete();
        }

        public void SetRating(int? rating)
        {
            if (rating.HasValue && (rating < 1 || rating > 5))
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 1 and 5");
            Rating = rating;
        }
    }
}
