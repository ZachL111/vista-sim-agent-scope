namespace VistaSimAgentScope;

public readonly record struct Signal(int Demand, int Capacity, int Latency, int Risk, int Weight);

public static class Policy
{
    private const int Threshold = 177;
    private const int RiskPenalty = 6;
    private const int LatencyPenalty = 4;
    private const int WeightBonus = 4;

    public static int Score(Signal signal) =>
        signal.Demand * 2 + signal.Capacity + signal.Weight * WeightBonus
        - signal.Latency * LatencyPenalty - signal.Risk * RiskPenalty;

    public static string Classify(Signal signal) => Score(signal) >= Threshold ? "accept" : "review";
}
