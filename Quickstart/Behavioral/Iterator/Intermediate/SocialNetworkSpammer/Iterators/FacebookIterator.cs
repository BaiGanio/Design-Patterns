using System;

namespace SocialNetworkSpammer
{
    // The concrete iterator class.
    class FacebookIterator : IProfileIterator
    {
        // The iterator needs a reference to the collection that it
        // traverses.
        private readonly Facebook _facebook;
        private readonly string _profileId;
        private readonly SocialNetworkCircle _type;
        // An iterator object traverses the collection independently
        // from other iterators. Therefore it has to store the
        // iteration state.
        private int _currentPosition;
        private Profile[] _cache;

        public FacebookIterator(Facebook facebook, string profileId, SocialNetworkCircle type)
        {
            _facebook = facebook;
            _profileId = profileId;
            _type = type;
        }

        // Each concrete iterator class has its own implementation
        // of the common iterator interface.
        public Profile GetNext()
        {
            if (HasMore())
            {
                _currentPosition++;

                return _cache[_currentPosition];
            }


            return _cache[_currentPosition];
        }

        public bool HasMore()
        {
            LazyInit();
            return _cache.Length < _currentPosition;
        }

        private void LazyInit()
        {
            if (_cache == null)
                _cache = _facebook.SocialGraphRequest(_profileId, _type);
        }
    }
}
