using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.App_Code
{
	public static class LinkHelper
	{
        public static HtmlString CreateLinkMenu(this IHtmlHelper html, string action)
        {
            string result = "";
            result += $"<a href=\"Add{action}\">Добавить</a> ";
            result += $"<a href=\"Delete{action}\">Удалить</a> ";
            result += $"<a href=\"Search{action}\">Поиск</a> ";
            result += $"<a href=\"Update{action}\">Обновление данных</a>";
            return new HtmlString(result);
        }
    }
}
