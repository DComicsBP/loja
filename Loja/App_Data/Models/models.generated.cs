//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "da3d28a166a9de7a")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.2")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Main Text</summary>
	[PublishedContentModel("mainText")]
	public partial class MainText : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "mainText";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MainText(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MainText, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Text - Main Text
		///</summary>
		[ImplementPropertyType("textMainText")]
		public IHtmlString TextMainText
		{
			get { return this.GetPropertyValue<IHtmlString>("textMainText"); }
		}

		///<summary>
		/// Text Title
		///</summary>
		[ImplementPropertyType("textTitle")]
		public string TextTitle
		{
			get { return this.GetPropertyValue<string>("textTitle"); }
		}
	}

	/// <summary>Links</summary>
	[PublishedContentModel("links")]
	public partial class Links : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "links";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Links(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Links, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Internal Links
		///</summary>
		[ImplementPropertyType("internalLinks")]
		public IPublishedContent InternalLinks
		{
			get { return this.GetPropertyValue<IPublishedContent>("internalLinks"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	// Mixin content Type 1206 with alias "header"
	/// <summary>Header</summary>
	public partial interface IHeader : IPublishedContent
	{
		/// <summary>Images - Header</summary>
		IEnumerable<IPublishedContent> ImagesHeader { get; }

		/// <summary>Links - Header</summary>
		IEnumerable<IPublishedContent> LinksHeader { get; }
	}

	/// <summary>Header</summary>
	[PublishedContentModel("header")]
	public partial class Header : PublishedContentModel, IHeader
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "header";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Header(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Header, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Images - Header
		///</summary>
		[ImplementPropertyType("imagesHeader")]
		public IEnumerable<IPublishedContent> ImagesHeader
		{
			get { return GetImagesHeader(this); }
		}

		/// <summary>Static getter for Images - Header</summary>
		public static IEnumerable<IPublishedContent> GetImagesHeader(IHeader that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("imagesHeader"); }

		///<summary>
		/// Links - Header
		///</summary>
		[ImplementPropertyType("linksHeader")]
		public IEnumerable<IPublishedContent> LinksHeader
		{
			get { return GetLinksHeader(this); }
		}

		/// <summary>Static getter for Links - Header</summary>
		public static IEnumerable<IPublishedContent> GetLinksHeader(IHeader that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("linksHeader"); }
	}

	// Mixin content Type 1218 with alias "footer"
	/// <summary>Footer</summary>
	public partial interface IFooter : IPublishedContent
	{
		/// <summary>description Footer</summary>
		IEnumerable<IPublishedContent> DescriptionFooter { get; }

		/// <summary>Title Footer</summary>
		string TitleFooter { get; }
	}

	/// <summary>Footer</summary>
	[PublishedContentModel("footer")]
	public partial class Footer : PublishedContentModel, IFooter
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "footer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Footer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Footer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// description Footer
		///</summary>
		[ImplementPropertyType("descriptionFooter")]
		public IEnumerable<IPublishedContent> DescriptionFooter
		{
			get { return GetDescriptionFooter(this); }
		}

		/// <summary>Static getter for description Footer</summary>
		public static IEnumerable<IPublishedContent> GetDescriptionFooter(IFooter that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("descriptionFooter"); }

		///<summary>
		/// Title Footer
		///</summary>
		[ImplementPropertyType("titleFooter")]
		public string TitleFooter
		{
			get { return GetTitleFooter(this); }
		}

		/// <summary>Static getter for Title Footer</summary>
		public static string GetTitleFooter(IFooter that) { return that.GetPropertyValue<string>("titleFooter"); }
	}

	// Mixin content Type 1220 with alias "descriptions"
	/// <summary>Descriptions</summary>
	public partial interface IDescriptions : IPublishedContent
	{
		/// <summary>Description Things</summary>
		IHtmlString DescriptionThings { get; }

		/// <summary>DTItle</summary>
		string DTitle { get; }
	}

	/// <summary>Descriptions</summary>
	[PublishedContentModel("descriptions")]
	public partial class Descriptions : PublishedContentModel, IDescriptions
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "descriptions";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Descriptions(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Descriptions, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Things
		///</summary>
		[ImplementPropertyType("descriptionThings")]
		public IHtmlString DescriptionThings
		{
			get { return GetDescriptionThings(this); }
		}

		/// <summary>Static getter for Description Things</summary>
		public static IHtmlString GetDescriptionThings(IDescriptions that) { return that.GetPropertyValue<IHtmlString>("descriptionThings"); }

		///<summary>
		/// DTItle
		///</summary>
		[ImplementPropertyType("dTItle")]
		public string DTitle
		{
			get { return GetDTitle(this); }
		}

		/// <summary>Static getter for DTItle</summary>
		public static string GetDTitle(IDescriptions that) { return that.GetPropertyValue<string>("dTItle"); }
	}

	/// <summary>Contact Us</summary>
	[PublishedContentModel("contactUs")]
	public partial class ContactUs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Client Email
		///</summary>
		[ImplementPropertyType("clientEmail")]
		public string ClientEmail
		{
			get { return this.GetPropertyValue<string>("clientEmail"); }
		}

		///<summary>
		/// Client Mesage
		///</summary>
		[ImplementPropertyType("clientMesage")]
		public string ClientMesage
		{
			get { return this.GetPropertyValue<string>("clientMesage"); }
		}

		///<summary>
		/// Client Name
		///</summary>
		[ImplementPropertyType("clientName")]
		public string ClientName
		{
			get { return this.GetPropertyValue<string>("clientName"); }
		}
	}

	// Mixin content Type 1235 with alias "abc"
	/// <summary>Alias</summary>
	public partial interface IAbc : IPublishedContent
	{
		/// <summary>Umbraco Url Alias</summary>
		string UmbracoUrlAlias { get; }
	}

	/// <summary>Alias</summary>
	[PublishedContentModel("abc")]
	public partial class Abc : PublishedContentModel, IAbc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "abc";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Abc(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Abc, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for Umbraco Url Alias</summary>
		public static string GetUmbracoUrlAlias(IAbc that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }
	}

	/// <summary>Master</summary>
	[PublishedContentModel("master")]
	public partial class Master : PublishedContentModel, IAbc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "master";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Master(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Master, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Page Breadcrumb
		///</summary>
		[ImplementPropertyType("pageBreadcrumb")]
		public bool PageBreadcrumb
		{
			get { return this.GetPropertyValue<bool>("pageBreadcrumb"); }
		}

		///<summary>
		/// Page Keywords
		///</summary>
		[ImplementPropertyType("pageKeywords")]
		public IEnumerable<string> PageKeywords
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("pageKeywords"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.Abc.GetUmbracoUrlAlias(this); }
		}
	}

	/// <summary>Content</summary>
	[PublishedContentModel("content")]
	public partial class Content : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "content";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Content(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IEnumerable<IPublishedContent> Description
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("description"); }
		}

		///<summary>
		/// Text Title
		///</summary>
		[ImplementPropertyType("textTitle")]
		public string TextTitle
		{
			get { return this.GetPropertyValue<string>("textTitle"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : Master, IDescriptions, IFooter, IHeader
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Things
		///</summary>
		[ImplementPropertyType("descriptionThings")]
		public IHtmlString DescriptionThings
		{
			get { return Umbraco.Web.PublishedContentModels.Descriptions.GetDescriptionThings(this); }
		}

		///<summary>
		/// DTItle
		///</summary>
		[ImplementPropertyType("dTItle")]
		public string DTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Descriptions.GetDTitle(this); }
		}

		///<summary>
		/// description Footer
		///</summary>
		[ImplementPropertyType("descriptionFooter")]
		public IEnumerable<IPublishedContent> DescriptionFooter
		{
			get { return Umbraco.Web.PublishedContentModels.Footer.GetDescriptionFooter(this); }
		}

		///<summary>
		/// Title Footer
		///</summary>
		[ImplementPropertyType("titleFooter")]
		public string TitleFooter
		{
			get { return Umbraco.Web.PublishedContentModels.Footer.GetTitleFooter(this); }
		}

		///<summary>
		/// Images - Header
		///</summary>
		[ImplementPropertyType("imagesHeader")]
		public IEnumerable<IPublishedContent> ImagesHeader
		{
			get { return Umbraco.Web.PublishedContentModels.Header.GetImagesHeader(this); }
		}

		///<summary>
		/// Links - Header
		///</summary>
		[ImplementPropertyType("linksHeader")]
		public IEnumerable<IPublishedContent> LinksHeader
		{
			get { return Umbraco.Web.PublishedContentModels.Header.GetLinksHeader(this); }
		}
	}

	/// <summary>Trabalhe Conosco</summary>
	[PublishedContentModel("trabalheConosco")]
	public partial class TrabalheConosco : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "trabalheConosco";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TrabalheConosco(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TrabalheConosco, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Lojas</summary>
	[PublishedContentModel("lojas")]
	public partial class Lojas : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "lojas";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Lojas(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Lojas, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Product Details</summary>
	[PublishedContentModel("productDetails")]
	public partial class ProductDetails : PublishedContentModel, INameItemList
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "productDetails";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProductDetails(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductDetails, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public IEnumerable<IPublishedContent> Category
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("category"); }
		}

		///<summary>
		/// Image Product
		///</summary>
		[ImplementPropertyType("imageProduct")]
		public IPublishedContent ImageProduct
		{
			get { return this.GetPropertyValue<IPublishedContent>("imageProduct"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("prodDescription")]
		public string ProdDescription
		{
			get { return this.GetPropertyValue<string>("prodDescription"); }
		}

		///<summary>
		/// Name
		///</summary>
		[ImplementPropertyType("prodName")]
		public string ProdName
		{
			get { return this.GetPropertyValue<string>("prodName"); }
		}

		///<summary>
		/// Value
		///</summary>
		[ImplementPropertyType("prodValue")]
		public string ProdValue
		{
			get { return this.GetPropertyValue<string>("prodValue"); }
		}
	}

	/// <summary>Loja Detatlhe</summary>
	[PublishedContentModel("lojaDetatlhe")]
	public partial class LojaDetatlhe : Lojas
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "lojaDetatlhe";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LojaDetatlhe(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LojaDetatlhe, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Produtos</summary>
	[PublishedContentModel("produtos")]
	public partial class Produtos : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "produtos";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Produtos(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Produtos, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Categories</summary>
	[PublishedContentModel("categories")]
	public partial class Categories : PublishedContentModel, IConteudo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "categories";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Categories(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Categories, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	// Mixin content Type 1269 with alias "conteudo"
	/// <summary>Conteudo</summary>
	public partial interface IConteudo : IPublishedContent
	{
	}

	/// <summary>Conteudo</summary>
	[PublishedContentModel("conteudo")]
	public partial class Conteudo : PublishedContentModel, IConteudo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "conteudo";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Conteudo(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Conteudo, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Images</summary>
	[PublishedContentModel("images")]
	public partial class Images : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "images";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Images(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Images, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}
	}

	/// <summary>Produto</summary>
	[PublishedContentModel("produto")]
	public partial class Produto : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "produto";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Produto(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Produto, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Cards
		///</summary>
		[ImplementPropertyType("cards")]
		public IEnumerable<IPublishedContent> Cards
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("cards"); }
		}
	}

	// Mixin content Type 1300 with alias "nameItemList"
	/// <summary>Name Item List</summary>
	public partial interface INameItemList : IPublishedContent
	{
	}

	/// <summary>Name Item List</summary>
	[PublishedContentModel("nameItemList")]
	public partial class NameItemList : PublishedContentModel, INameItemList
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "nameItemList";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NameItemList(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NameItemList, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
