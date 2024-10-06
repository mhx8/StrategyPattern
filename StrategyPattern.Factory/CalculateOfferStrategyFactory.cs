using ExternalLib.External;

namespace StrategyPattern.Solution;

public delegate ICalculateOfferStrategy CalculateOfferStrategyFactory(Company company);