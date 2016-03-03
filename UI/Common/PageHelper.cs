using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace UI.Common
{
    public class PageHelper
    {
        public static string GetNumericPage(int pageIndex, int pageCount)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<a class='btn btn-primary href=?pIndex=1> < </a>");
            //1 2 3 4 5
            if (pageCount <= 5)
            {
                for (int i = 1; i <= pageCount; i++)
                {
                    if (pageIndex == i)
                    {
                        sb.Append(i + " ");
                    }
                    else
                    {
                        sb.Append("<a class='btn btn-info' href='?pIndex=" + i + "'>" + i + "</a> ");
                    }
                }
            }
            else //pageindex < 5
            {
                //1 ... 4 5 6 ... 10

                if (pageIndex == 1)//First Page
                {
                    sb.Append("1 ");
                    for (int i = 2; i <= 4; i++)
                    {
                        sb.Append("<a class='btn btn-info' href='?pIndex=" + i + "'>" + i + "</a> ");
                    }
                    sb.Append("... <a class='btn btn-info' href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else if (pageIndex == pageCount)//Last Page
                {
                    sb.Append("<a class='btn btn-info' href='?pIndex=1'>1</a> ... ");
                    for (int i = pageCount - 3; i < pageCount; i++)
                    {
                        sb.Append("<a class='btn btn-info' href='?pIndex=" + i + "'>" + i + "</a> ");
                    }
                    sb.Append(pageCount);
                }
                else if (pageIndex == 2)
                {
                    //1 2 3 4 ...10
                    sb.Append("<a class='btn btn-info' href='?pIndex=1'>1</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append("<a class='btn btn-info' href='?pIndex=3'>3</a> ");
                    sb.Append("<a class='btn btn-info' href='?pIndex=4'>4</a> ");
                    sb.Append("... <a class='btn btn-info' href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else if (pageIndex == 3)
                {
                    //1 2 3 4 ...10
                    sb.Append("<a class='btn btn-info' href='?pIndex=1'>1</a> ");
                    sb.Append("<a class='btn btn-info' href='?pIndex=2'>2</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append("<a class='btn btn-info' href='?pIndex=4'>4</a> ");
                    sb.Append("... <a class='btn btn-info' href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else if (pageIndex == (pageCount - 1))
                {
                    sb.Append("<a class='btn btn-info' href='?pIndex=1'>1</a> ...");
                    sb.Append("<a class='btn btn-info' href='?pIndex=" + (pageIndex - 2) + "'>" + (pageIndex - 2) + "</a> ");
                    sb.Append(" <a class='btn btn-info' href='?pIndex=" + (pageIndex - 1) + "'>" + (pageIndex - 1) + "</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append(" <a class='btn btn-info' href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");

                }
                else if (pageIndex == (pageCount - 2))
                {
                    sb.Append("<a class='btn btn-info' href='?pIndex=1'>1</a> ...");
                    sb.Append("<a class='btn btn-info' href='?pIndex=" + (pageIndex - 1) + "'>" + (pageIndex - 1) + "</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append(" <a class='btn btn-info' href='?pIndex=" + (pageIndex + 1) + "'>" + (pageIndex + 1) + "</a> ");
                    sb.Append(" <a class='btn btn-info' href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
                else
                {
                    sb.Append("<a class='btn btn-info' href='?pIndex=1'>1</a> ...");
                    sb.Append("<a class='btn btn-info' href='?pIndex=" + (pageIndex - 1) + "'>" + (pageIndex - 1) + "</a> ");
                    sb.Append(pageIndex + " ");
                    sb.Append("<a class='btn btn-info' href='?pIndex=" + (pageIndex + 1) + "'>" + (pageIndex + 1) + "</a> ");
                    sb.Append("... <a class='btn btn-info' href='?pIndex=" + pageCount + "'>" + pageCount + "</a>");
                }
            }
            return sb.ToString();
        }
    }
}