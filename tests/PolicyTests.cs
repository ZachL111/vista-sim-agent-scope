using VistaSimAgentScope;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(52, 89, 13, 22, 12);
        if (Policy.Score(signalcase_1) != 57) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(91, 86, 23, 18, 6);
        if (Policy.Score(signalcase_2) != 92) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(79, 75, 9, 25, 4);
        if (Policy.Score(signalcase_3) != 63) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
