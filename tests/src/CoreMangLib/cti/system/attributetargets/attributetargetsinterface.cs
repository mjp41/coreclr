using System;
/// <summary>
///Interface
/// </summary>

public class AttributeTargetsInterface
{
    public static int Main()
    {
        AttributeTargetsInterface AttributeTargetsInterface = new AttributeTargetsInterface();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsInterface");
        if (AttributeTargetsInterface.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Interface value is 0x0400. ");
        try
        {
            int expectValue = 0x0400;
            if ((int)AttributeTargets.Interface != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Interface should return 0x0400.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

