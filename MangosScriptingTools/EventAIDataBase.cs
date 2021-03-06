﻿using EventIAConstructor.EventAI.Metadata;
using EventIAConstructor.EventAI.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EventIAConstructor
{
    public class EventAIDataBase
    {
        static List<int[]> testData = new List<int[]>{
            new []{ 1, 2,  3, 4, 5,  1,  5,6,8,9,  12, 9,8,7,  11, 6,3,1,  10, 3,6,9 },
            new []{ 2, 5,  5, 7, 9,  5,  9,1,3,2,  17, 7,9,8,  14, 1,3,2,  13, 1,5,7 },
            new []{ 3, 10, 6, 3, 1,  22, 8,7,3,2,  19, 6,7,7,  16, 5,4,2,  18, 4,8,8 },
        };

        static EventAIDataBase()
        {
            //foreach (var arr in testData)
            //{
            //    var ai = new EventAIModel(arr[0], arr[1], arr[2], arr[3], arr[4]);
            //    var ev = new EventModel(ai, arr[5], arr[6], arr[7], arr[8], arr[9]);
            //    var action1 = new ActionModel(ai, arr[10], arr[11], arr[12], arr[13]);
            //    var action2 = new ActionModel(ai, arr[14], arr[15], arr[16], arr[17]);
            //    var action3 = new ActionModel(ai, arr[18], arr[19], arr[20], arr[21]);
            //    ai.Event = ev;
            //    ai.Action1 = action1;
            //    ai.Action2 = action2;
            //    ai.Action3 = action3;

            //    EventAIList.Add(ai);
            //}
        }

        public static EventAIDataBase Instance { get; private set; } = new EventAIDataBase();

        public static ObservableCollection<EventAIModel> EventAIList { get; set; } = new ObservableCollection<EventAIModel>();
    }
}