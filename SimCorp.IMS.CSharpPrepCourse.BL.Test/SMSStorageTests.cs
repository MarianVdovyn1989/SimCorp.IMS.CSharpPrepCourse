using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Tests
{
    [TestClass()]
    public class SMSStorageTests
    {
        DateTime FakeDateTime;
        List<SMS> Messages;
        List<SMS> ExpectedFilteredMessages1;
        List<SMS> ExpectedFilteredMessages2;
        List<SMS> ExpectedFilteredMessages3;
        SMSFilterState FiltersState;
        ComboBox UserSelectedSender;
        DateTimePicker FilterFrom;
        DateTimePicker FilterTo;
        TextBox TextToSearch;
        SMSFormEventArgs E;
        object _sender = "TestsSnder";
        public class FakeSMSStorage : SMSStorage
        {
            SMS Message;
            SMSFormEventArgs e;
            SMSFilterState _filtersState;
            public FakeSMSStorage(SMSFilterState filterState, List<SMS> filteredMessages, SMSFormEventArgs e) : base(filterState, filteredMessages)
            {
                Message = new SMS() { Text = "message: SMSReceived event is raised" };
                this.e = e;
                e.Text.Text = "message: StateUpdated event is raised";
                _filtersState = filterState;
            }
            private string _property_OnSMSReceived;

            public string Property_OnSMSReceived
            {
                set
                {
                    if (_property_OnSMSReceived != value)
                    {
                        _property_OnSMSReceived = value;
                        SMSProvider.OnSMSReceived(Message);
                    }
                }
            }
            private string _property_OnFilterStateUpdated;
            public string Property_OnFilterStateUpdated
            {
                set
                {
                    if (_property_OnFilterStateUpdated != value)
                    {
                        _property_OnFilterStateUpdated = value;
                        _filtersState.OnFilterStateUpdated(e);
                    }
                }
            }
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            FakeDateTime = new DateTime(2020, 12, 2, 18, 36, 00);
            Messages = new List<SMS>();
            Messages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #1",
                TimeReceived = FakeDateTime.AddSeconds(1)
            });
            Messages.Add(new SMS()
            {
                Sender = "Bank",
                Text = "test text message #2",
                TimeReceived = FakeDateTime.AddSeconds(2)
            });
            Messages.Add(new SMS()
            {
                Sender = "YourBro",
                Text = "test text message #3",
                TimeReceived = FakeDateTime.AddSeconds(3)
            });
            Messages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #4",
                TimeReceived = FakeDateTime.AddSeconds(4)
            });
            Messages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test unique text message #5",
                TimeReceived = FakeDateTime.AddSeconds(5)
            });
            Messages.Add(new SMS()
            {
                Sender = "YourBro",
                Text = "test text message #6",
                TimeReceived = FakeDateTime.AddSeconds(6)
            });
            ExpectedFilteredMessages1 = new List<SMS>();
            ExpectedFilteredMessages1.Add(new SMS()
            {
                Sender = "Bank",
                Text = "test text message #2",
                TimeReceived = FakeDateTime.AddSeconds(2)
            });
            ExpectedFilteredMessages3 = new List<SMS>();
            ExpectedFilteredMessages3.Add(new SMS()
            {
                Sender = "YourBro",
                Text = "test text message #3",
                TimeReceived = FakeDateTime.AddSeconds(3)
            });
            FiltersState = new SMSFilterState(ExpectedFilteredMessages1);
            //Default Filters Criteria
            UserSelectedSender = new ComboBox();
            UserSelectedSender.Items.Add("All");
            UserSelectedSender.SelectedIndex = 0;

            FilterFrom = new DateTimePicker();
            FilterFrom.Value = DateTimePicker.MinimumDateTime;

            FilterTo = new DateTimePicker();
            FilterTo.Value = DateTimePicker.MaximumDateTime;

            TextToSearch = new TextBox();
            TextToSearch.Text = "";

            E = new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { };
            FiltersState = new SMSFilterState(ExpectedFilteredMessages1);
        }

        [TestMethod()]
        public void FilterBySenderTest()
        {
            //Arrenge
            //Create and fill SMS Repository
            SMSStorage sMSStorage = new SMSStorage(FiltersState, ExpectedFilteredMessages1);
            AddMessagesToSMSStorage(sMSStorage);
            //Create Filter Criteria
            UserSelectedSender.Items.Add("Bank");
            UserSelectedSender.SelectedIndex = 1;
            //Act
            FiltersState.Update(_sender, new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { });
            //Assert
            Assert.AreEqual(1, sMSStorage.FilteredMessages.Count);
            Assert.AreEqual(ExpectedFilteredMessages1[0].Sender, sMSStorage.FilteredMessages[0].Sender);
            Assert.AreEqual(ExpectedFilteredMessages1[0].Text, sMSStorage.FilteredMessages[0].Text);
            Assert.AreEqual(ExpectedFilteredMessages1[0].TimeReceived, sMSStorage.FilteredMessages[0].TimeReceived);
        }
        [TestMethod()]
        public void FilterBySender_MultipleReturnedMessages_OrderedByTimeReceivedTest()
        {
            //Arrenge
            //Create and fill SMS Repository
            SMSStorage sMSStorage = new SMSStorage(FiltersState, ExpectedFilteredMessages1);
            AddMessagesToSMSStorage(sMSStorage);
            //Create Filter Criteria
            UserSelectedSender.Items.Add("Mom");
            UserSelectedSender.SelectedIndex = 1;
            //Create Expected Filtered Messages
            ExpectedFilteredMessages2 = new List<SMS>();
            ExpectedFilteredMessages2.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #1",
                TimeReceived = FakeDateTime.AddSeconds(1)
            });
            ExpectedFilteredMessages2.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #4",
                TimeReceived = FakeDateTime.AddSeconds(4)
            });
            ExpectedFilteredMessages2.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test unique text message #5",
                TimeReceived = FakeDateTime.AddSeconds(5)
            });
            //Act
            FiltersState.Update(_sender, new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { });
            //Assert
            Assert.AreEqual(3, sMSStorage.FilteredMessages.Count);
            Assert.AreEqual(ExpectedFilteredMessages2[0].Sender, sMSStorage.FilteredMessages[0].Sender);
            Assert.AreEqual(ExpectedFilteredMessages2[0].Text, sMSStorage.FilteredMessages[0].Text);
            Assert.AreEqual(ExpectedFilteredMessages2[0].TimeReceived, sMSStorage.FilteredMessages[0].TimeReceived);
            Assert.AreEqual(ExpectedFilteredMessages2[1].Sender, sMSStorage.FilteredMessages[1].Sender);
            Assert.AreEqual(ExpectedFilteredMessages2[1].Text, sMSStorage.FilteredMessages[1].Text);
            Assert.AreEqual(ExpectedFilteredMessages2[1].TimeReceived, sMSStorage.FilteredMessages[1].TimeReceived);
            Assert.AreEqual(ExpectedFilteredMessages2[2].Sender, sMSStorage.FilteredMessages[2].Sender);
            Assert.AreEqual(ExpectedFilteredMessages2[2].Text, sMSStorage.FilteredMessages[2].Text);
            Assert.AreEqual(ExpectedFilteredMessages2[2].TimeReceived, sMSStorage.FilteredMessages[2].TimeReceived);
        }
        [TestMethod()]
        public void FilterByTextTest()
        {
            //Arrenge
            //Create and fill SMS Repository
            SMSStorage sMSStorage = new SMSStorage(FiltersState, ExpectedFilteredMessages1);
            AddMessagesToSMSStorage(sMSStorage);
            //Create Filter Criteria
            TextToSearch.Text = "#3";
            //Act
            FiltersState.Update(_sender, new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { });
            //Assert
            Assert.AreEqual(1, sMSStorage.FilteredMessages.Count);
            Assert.AreEqual(ExpectedFilteredMessages3[0].Sender, sMSStorage.FilteredMessages[0].Sender);
            Assert.AreEqual(ExpectedFilteredMessages3[0].Text, sMSStorage.FilteredMessages[0].Text);
            Assert.AreEqual(ExpectedFilteredMessages3[0].TimeReceived, sMSStorage.FilteredMessages[0].TimeReceived);
        }
        [TestMethod()]
        public void FilterByFilterFrom_ReturnMessagesBiggerOrEqualThanFilterFromTest()
        {
            //Arrenge
            //Create and fill SMS Repository
            SMSStorage sMSStorage = new SMSStorage(FiltersState, ExpectedFilteredMessages1);
            AddMessagesToSMSStorage(sMSStorage);
            //Create Filter Criteria
            FilterFrom.Value = FakeDateTime.AddSeconds(6);
            //Create Expected Filtered Messages
            var ExpectedMessages = new List<SMS>();
            ExpectedMessages.Add(new SMS()
            {
                Sender = "YourBro",
                Text = "test text message #6",
                TimeReceived = FakeDateTime.AddSeconds(6)
            });
            //Act
            FiltersState.Update(_sender, new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { });
            //Assert
            Assert.AreEqual(1, sMSStorage.FilteredMessages.Count);
            Assert.AreEqual(ExpectedMessages[0].Sender, sMSStorage.FilteredMessages[0].Sender);
            Assert.AreEqual(ExpectedMessages[0].Text, sMSStorage.FilteredMessages[0].Text);
            Assert.AreEqual(ExpectedMessages[0].TimeReceived, sMSStorage.FilteredMessages[0].TimeReceived);
        }
        [TestMethod()]
        public void FilterByFilterTo_ReturnMessagesThatAreLessThanFilterToTest()
        {
            //Arrenge
            //Create and fill SMS Repository
            SMSStorage sMSStorage = new SMSStorage(FiltersState, ExpectedFilteredMessages1);
            AddMessagesToSMSStorage(sMSStorage);
            //Create Filter Criteria
            FilterTo.Value = FakeDateTime.AddSeconds(2);
            //Create Expected Filtered Messages
            var ExpectedMessages = new List<SMS>();
            ExpectedMessages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #1",
                TimeReceived = FakeDateTime.AddSeconds(1)
            });
            //Act
            FiltersState.Update(_sender, new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { });
            //Assert
            Assert.AreEqual(1, sMSStorage.FilteredMessages.Count);
            Assert.AreEqual(ExpectedMessages[0].Sender, sMSStorage.FilteredMessages[0].Sender);
            Assert.AreEqual(ExpectedMessages[0].Text, sMSStorage.FilteredMessages[0].Text);
            Assert.AreEqual(ExpectedMessages[0].TimeReceived, sMSStorage.FilteredMessages[0].TimeReceived);
        }
        [TestMethod()]
        public void FilterByMultipleFilterCriteria_Test()
        {
            //Arrenge
            //Create and fill SMS Repository
            SMSStorage sMSStorage = new SMSStorage(FiltersState, ExpectedFilteredMessages1);
            AddMessagesToSMSStorage(sMSStorage);
            //Create Filter Criteria
            UserSelectedSender.Items.Add("Mom");
            UserSelectedSender.SelectedIndex = 1;
            FilterFrom.Value = FakeDateTime.AddSeconds(2);
            FilterTo.Value = FakeDateTime.AddSeconds(6);
            TextToSearch.Text = "unique";
            //Create Expected Filtered Messages
            var ExpectedMessages = new List<SMS>();
            ExpectedMessages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test unique text message #5",
                TimeReceived = FakeDateTime.AddSeconds(5)
            });
            //Act
            FiltersState.Update(_sender, new SMSFormEventArgs(UserSelectedSender, FilterFrom, FilterTo, TextToSearch) { });
            //Assert
            Assert.AreEqual(1, sMSStorage.FilteredMessages.Count);
            Assert.AreEqual(ExpectedMessages[0].Sender, sMSStorage.FilteredMessages[0].Sender);
            Assert.AreEqual(ExpectedMessages[0].Text, sMSStorage.FilteredMessages[0].Text);
            Assert.AreEqual(ExpectedMessages[0].TimeReceived, sMSStorage.FilteredMessages[0].TimeReceived);
        }

        [TestMethod]
        public void TestThatSMSReceivedEventIsRaised()
        {
            //Arrenge
            List<SMS> actualEvents = new List<SMS>();
            FakeSMSStorage storage = new FakeSMSStorage(FiltersState, ExpectedFilteredMessages1, E);
            //Assign Anonymous Event Handler
            SMSProvider.SMSReceived += (SMS message) =>
                actualEvents.Add(message);
            //Act
            storage.Property_OnSMSReceived = "SMSReceived Event Invoked";
            //Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsNotNull(actualEvents[0].ToString());
            Assert.AreEqual("message: SMSReceived event is raised", actualEvents[0].Text);
        }
        [TestMethod]
        public void TestThatStateUpdateEventIsRaised()
        {
            //Arrenge
            List<SMS> actualEvents = new List<SMS>();
            FakeSMSStorage storage = new FakeSMSStorage(FiltersState, ExpectedFilteredMessages1, E);
            //Assign Anonymous Event Handler
            FiltersState.StateUpdated += (_sender, E) =>
                actualEvents.Add(new SMS { Text = E.Text.Text });
            //Act
            storage.Property_OnFilterStateUpdated = "StateUpdated Event Invoked";
            //Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsNotNull(actualEvents[0].ToString());
            Assert.AreEqual("message: StateUpdated event is raised", actualEvents[0].Text);
        }

        [TestMethod]
        public void AddToStorageTest()
        {
            //Arrenge
            FakeSMSStorage storage = new FakeSMSStorage(FiltersState, ExpectedFilteredMessages1, E);
            var ExpectedMessage = new SMS()
            {
                Sender = "Mom",
                Text = "test text message #1",
                TimeReceived = FakeDateTime.AddSeconds(1)
            };
            //Act
            storage.AddToStorage(ExpectedMessage);
            //Assert
            Assert.AreEqual(1, storage.Messages.Count);
            Assert.AreEqual(ExpectedMessage.Sender, storage.Messages[0].Sender);
            Assert.AreEqual(ExpectedMessage.Text, storage.Messages[0].Text);
            Assert.AreEqual(ExpectedMessage.TimeReceived, storage.Messages[0].TimeReceived);

        }
        [TestMethod]
        public void RemoveOneMessageFromStorageTest()
        {
            //Arrenge
            FakeSMSStorage storage = new FakeSMSStorage(FiltersState, ExpectedFilteredMessages1, E);
            AddMessagesToSMSStorage(storage);
            var SelectedByUserToBeRemovedMessages = new List<SMS>();
            SelectedByUserToBeRemovedMessages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #1",
                TimeReceived = FakeDateTime.AddSeconds(1)
            });
            //Act
            storage.RemoveFromStorage(SelectedByUserToBeRemovedMessages);
            //Assert
            Assert.AreEqual(5, storage.Messages.Count);
            foreach (var message in storage.Messages)
            {
                Assert.IsFalse(SelectedByUserToBeRemovedMessages[0].TimeReceived == message.TimeReceived && SelectedByUserToBeRemovedMessages[0].Sender == message.Sender, "message/s with the same TimeReceived and Sender still exists");
            }

        }
        [TestMethod]
        public void RemoveSeveralMessagesFromStorageTest()
        {
            //Arrenge
            FakeSMSStorage storage = new FakeSMSStorage(FiltersState, ExpectedFilteredMessages1, E);
            AddMessagesToSMSStorage(storage);
            var SelectedByUserToBeRemovedMessages = new List<SMS>();
            SelectedByUserToBeRemovedMessages.Add(new SMS()
            {
                Sender = "Mom",
                Text = "test text message #1",
                TimeReceived = FakeDateTime.AddSeconds(1)
            });
            SelectedByUserToBeRemovedMessages.Add(new SMS()
            {
                Sender = "YourBro",
                Text = "test text message #3",
                TimeReceived = FakeDateTime.AddSeconds(3)
            });
            //Act
            storage.RemoveFromStorage(SelectedByUserToBeRemovedMessages);
            //Assert
            Assert.AreEqual(4, storage.Messages.Count);
            foreach (var message in storage.Messages)
            {
                Assert.IsFalse(SelectedByUserToBeRemovedMessages[0].TimeReceived == message.TimeReceived && SelectedByUserToBeRemovedMessages[0].Sender == message.Sender, "message/s with the same TimeReceived and Sender still exists");
                Assert.IsFalse(SelectedByUserToBeRemovedMessages[1].TimeReceived == message.TimeReceived && SelectedByUserToBeRemovedMessages[1].Sender == message.Sender, "message/s with the same TimeReceived and Sender still exists");
            }

        }

        private void AddMessagesToSMSStorage(SMSStorage fakeSMSStorage)
        {
            foreach (var message in Messages)
            {
                fakeSMSStorage.AddToStorage(message);
            }
        }

    }
}