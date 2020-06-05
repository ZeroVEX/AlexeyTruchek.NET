using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using BLL.DTO;

namespace WebUI.App_Code
{
	public static class ListHelper
	{
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<UserDTO> items)
        {
            string result = "";
            result += "<table>";
            result += "<tr>";
            result += "<td>ID</td>";
            result += "<td>Логин</td>";
            result += "<td>Пароль</td>";
            result += "<td>Название компании</td>";
            result += "</tr>";
            foreach (var item in items)
            {
                result += "<tr>";
                result += $"<td>{item.ID}</td>";
                result += $"<td>{item.Login}</td>";
                result += $"<td>{item.Password}</td>";
                result += $"<td>{item.CompanyName}</td>";
                result += "</tr>";
            }
            result += "</table>";
            return new HtmlString(result);
        }
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<ProductDTO> items)
        {
            string result = "";
            result += "<table>";
            result += "<tr>";
            result += "<td>ID</td>";
            result += "<td>Название</td>";
            result += "</tr>";
            foreach (var item in items)
            {
                result += "<tr>";
                result += $"<td>{item.ID}</td>";
                result += $"<td>{item.Title}</td>";
                result += "</tr>";
            }
            result += "</table>";
            return new HtmlString(result);
        }
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<IngredientDTO> items)
        {
            string result = "";
            result += "<table>";
            result += "<tr>";
            result += "<td>ID</td>";
            result += "<td>Название</td>";
            result += "</tr>";
            foreach (var item in items)
            {
                result += "<tr>";
                result += $"<td>{item.ID}</td>";
                result += $"<td>{item.Title}</td>";
                result += "</tr>";
            }
            result += "</table>";
            return new HtmlString(result);
        }
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<RecipeDTO> items)
        {
            string result = "";
            result += "<table>";
            result += "<tr>";
            result += "<td>ID</td>";
            result += "<td>ID продукта</td>";
            result += "<td>ID ингредиента</td>";
            result += "<td>Количество</td>";
            result += "</tr>";
            foreach (var item in items)
            {
                result += "<tr>";
                result += "<td>{item.ID}</td>";
                result += "<td>{item.ProductID}</td>";
                result += "<td>{item.IngredientID}</td>";
                result += "<td>{item.Quantity}</td>";
                result += "</tr>";
            }
            result += "</table>";
            return new HtmlString(result);
        }
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<OrderDTO> items)
        {
            string result = "";
            result += "<table>";
            result += "<tr>";
            result += "<td>ID</td>";
            result += "<td>ID пользователя</td>";
            result += "<td>ID продукта</td>";
            result += "<td>Количество</td>";
            result += "<td>Дата</td>";
            result += "</tr>";
            foreach (var item in items)
            {
                result += "<tr>";
                result += $"<td>{item.ID}</td>";
                result += $"<td>{item.UserID}</td>";
                result += $"<td>{item.ProductID}</td>";
                result += $"<td>{item.Quantity}</td>";
                result += $"<td>{item.Date}</td>";
                result += "</tr>";
            }
            result += "</table>";
            return new HtmlString(result);
        }
    }
}
