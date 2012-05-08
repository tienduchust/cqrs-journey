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
namespace Conference.Specflow.Features.Management.SeatTypes
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature : Xunit.IUseFixture<SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SeatTypesConfiguration.feature"
#line hidden
        
        public SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Seat Types configuration scenarios for creating and editing Seat Types settings", "In order to create or update a Seat Type\r\nAs a Business Customer\r\nI want to be ab" +
                    "le to create or update a Seat Type and set its properties", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 19
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table1.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012S",
                        "CQRS summit 2012 conference (Seat Assignment)",
                        "cqrs2012p",
                        "05/02/2012",
                        "05/12/2012"});
#line 20
testRunner.Given("an existing unpublished conference with this information", ((string)(null)), table1);
#line hidden
        }
        
        public virtual void SetFixture(SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Seat Types configuration scenarios for creating and editing Seat Types settings")]
        [Xunit.TraitAttribute("Description", "Seat Types are created and assigned to an existing Conference")]
        public virtual void SeatTypesAreCreatedAndAssignedToAnExistingConference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seat Types are created and assigned to an existing Conference", new string[] {
                        "Ignore"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Quantity",
                        "Price"});
            table2.AddRow(new string[] {
                        "GENADM",
                        "General admission",
                        "100",
                        "199"});
#line 26
testRunner.Given("the information for the new Seat Types", ((string)(null)), table2);
#line 29
testRunner.When("the Business Customer proceed to create the Seat Types");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Quantity",
                        "Price"});
            table3.AddRow(new string[] {
                        "GENADM",
                        "General admission",
                        "100",
                        "199,00"});
#line 30
testRunner.Then("the new Seat Types with this information are created", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Seat Types configuration scenarios for creating and editing Seat Types settings")]
        [Xunit.TraitAttribute("Description", "Seat Types are edited from existing Conference")]
        public virtual void SeatTypesAreEditedFromExistingConference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seat Types are edited from existing Conference", new string[] {
                        "Ignore"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Quantity",
                        "Price"});
            table4.AddRow(new string[] {
                        "GENADM",
                        "General admission",
                        "100",
                        "199"});
#line 36
testRunner.Given("the existing Seat Types", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Quantity"});
            table5.AddRow(new string[] {
                        "200"});
#line 39
testRunner.And("the updated information", ((string)(null)), table5);
#line 42
testRunner.When("the Business Customer proceed to save the changes");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Quantity"});
            table6.AddRow(new string[] {
                        "200"});
#line 43
testRunner.Then("the updated Seat Type will show up", ((string)(null)), table6);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Seat Types configuration scenarios for creating and editing Seat Types settings")]
        [Xunit.TraitAttribute("Description", "Seat Types are deleted from existing Conference")]
        public virtual void SeatTypesAreDeletedFromExistingConference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Seat Types are deleted from existing Conference", new string[] {
                        "Ignore"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Quantity",
                        "Price"});
            table7.AddRow(new string[] {
                        "GENADM",
                        "General admission",
                        "100",
                        "199"});
#line 49
testRunner.Given("the existing Seat Types", ((string)(null)), table7);
#line 52
testRunner.When("the Business Customer proceed to delete the selected Seat Type");
#line 53
testRunner.Then("the Seat Type is removed from the Conference");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SeatTypesConfigurationScenariosForCreatingAndEditingSeatTypesSettingsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
