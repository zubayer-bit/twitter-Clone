using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal class Follow
    {
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followedAt;

        public Follow()
        {
            _followedAt = DateTime.Now;
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
        }
    }
}
