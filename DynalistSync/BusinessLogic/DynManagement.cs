using System;
using DynalistSync.Models;

namespace DynalistSync.BusinessLogic
{
    public class DynManagement
    {
        public DynFile getFileByName(DynResp doc, string title)
        {
         
            return doc.files.Find(elem => elem.title.ToLower().Contains(title.ToLower()));
               

        }

        public System.Collections.Generic.List<Node> getUncheckItem(DynDoc doc)
        {
            String today = "!(" + DateTime.Now.Year + "-0" + DateTime.Now.Month + "-" + DateTime.Now.Day + ")"; 

            return doc.nodes.FindAll(elem => !elem.@checked.HasValue  && elem.content.Contains(today));


        }



        public DynManagement()
        {
        }
    }
}
