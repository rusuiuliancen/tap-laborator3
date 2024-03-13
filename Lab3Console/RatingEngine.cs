using Lab3Console.Factory;
using Lab3Console.FileSource;
using Lab3Console.Logger;
using Lab3Console.PolicySerializer;

namespace Lab3Console
{
    public class RatingEngine
    {
        private ILogger _logger;
        private IFileSource _fileSource;
        private IPolicySerializer _policySerializer;
        private IRaterFactory _factory;

        public RatingEngine(ILogger logger, IFileSource fileSource, IPolicySerializer policySerializer, IRaterFactory factory)
        {
            _logger = logger;
            _fileSource = fileSource;
            _policySerializer = policySerializer;
            _factory = factory;
        }

        public decimal Rating { get; set; }
        public void Rate()
        {
            _logger.Log("Starting rate.");
            _logger.Log("Loading policy.");

            var policyJson = _fileSource.GetPolicySource();

            var policy = _policySerializer.GetPolicyFromJsonString(policyJson);
            
            var rater = _factory.Create(policy);
            Rating = rater.Rate(policy);

            _logger.Log("Rating completed.");
        }
    }
}
