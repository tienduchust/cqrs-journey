﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature : Xunit.IUseFixture<RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationEndToEndSad.feature"
#line hidden
        
        public RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
                    "th)", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\nI want" +
                    " to be able to select Order Items from one or many available Order Items and mak" +
                    "e a Reservation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 20
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "20"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "20"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "20"});
#line 21
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
        }
        
        public virtual void SetFixture(RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "All the Order Items are selected and none are available, then none get reserved")]
        public virtual void AllTheOrderItemsAreSelectedAndNoneAreAvailableThenNoneGetReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are selected and none are available, then none get reserved", ((string[])(null)));
#line 30
 this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "3"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 31
  testRunner.Given("the selected Order Items", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "18"});
            table3.AddRow(new string[] {
                        "CQRS Workshop",
                        "20"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "10"});
#line 36
 testRunner.And("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table3);
#line 41
 testRunner.And("the Registrant proceed to make the Reservation with seats already reserved");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "selected",
                        "message"});
            table4.AddRow(new string[] {
                        "General admission",
                        "2",
                        "Could not reserve all the requested seats."});
            table4.AddRow(new string[] {
                        "CQRS Workshop",
                        "0",
                        "Could not reserve all the requested seats."});
            table4.AddRow(new string[] {
                        "Additional cocktail party",
                        "2",
                        ""});
#line 42
 testRunner.And("the Registrant is offered to select any of these available seats", ((string)(null)), table4);
#line 47
 testRunner.And("the total should read $498");
#line 48
 testRunner.When("the Registrant proceed to make the Reservation");
#line 49
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "General admission",
                        "2"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 50
 testRunner.And("these Order Items should be reserved", ((string)(null)), table5);
#line 54
 testRunner.And("the total should read $498");
#line 55
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "Allocate some purchased Seats")]
        public virtual void AllocateSomePurchasedSeats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate some purchased Seats", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "Additional cocktail party",
                        "4"});
#line 59
  testRunner.Given("the selected Order Items", ((string)(null)), table6);
#line 62
 testRunner.And("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table7.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 63
 testRunner.And("the Registrant enter these details", ((string)(null)), table7);
#line 66
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 67
 testRunner.And("the Registrant proceed to confirm the payment");
#line 68
    testRunner.And("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "Additional cocktail party",
                        "4"});
#line 69
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table8);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "first name",
                        "last name",
                        "email address"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "Mani",
                        "Kris",
                        "Mani@Kris.com"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "Jim",
                        "Gregory",
                        "Jim@Gregory.com"});
#line 72
 testRunner.When("the Registrant assign these seats", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table10.AddRow(new string[] {
                        "Additional cocktail party",
                        "4"});
#line 76
 testRunner.Then("these seats are assigned", ((string)(null)), table10);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
