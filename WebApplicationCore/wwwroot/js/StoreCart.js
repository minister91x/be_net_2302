AddItemToCart = function (e) {
    debugger;

    var item = {
        ProductID: $(e).data('productid'),
        ProductName: $(e).data('productname'),
        Quality: 1,
        CustomPrice: $(e).data('price'),
    };
    console.log(item);
    if (item.ProductID == 0) {
        $("#btnAddtoCartErr").show();
        $("#btnAddtoCartErr").text("Vui lòng chọn  ít nhất 01 " + $("#txtProductAttrGroupNameBuy").val(), 0);
        return;
    } else {
        $("#btnAddtoCartErr").hide();
    }
    var store = GetCookie('ShoppingCart');
    store = AddAndUpdateShoppingCart(store, item);

}


AddItemFromChangeQuantityToCart = function (e, productid) {

    var quantity = $("#txtQuantity_" + productid).val();
    quantity = parseInt(quantity, 10);

    var price = parseInt($(e).data('price'), 10);
    if (quantity > 0) {
        if (quantity > 10) {
            $("#txtQuantity_" + productid).val(10);
            $("#TotalAmount_" + productid).text(FormatMoney(price * 10));
        }
        $("#TotalAmount_" + productid).text(FormatMoney(price * parseInt(quantity, 10)));
    } else {
        $("#txtQuantity_" + productid).val(1);
        $("#TotalAmount_" + productid).text(FormatMoney(price));
    }

    var item = {
        ProductID: $(e).data('product'),
        ProductName: $(e).data('productname'),
        Quality: quantity,
        CustomPrice: price,
        Image: $(e).data('image')

    };

    var store = GetCookie('ShoppingCart');
    store = AddAndUpdateShoppingCart(store, item, quantity);

    UpdateShoppingCartView(store, 2);

}

AddItemByQuantityFromProductDetailToCart = function (e, productid) {

    var quantity = $("#txtQuantity_" + productid).val();
    quantity = parseInt(quantity, 10);
    var price = parseInt($(e).data('price'), 10);

    var item = {
        ProductID: $(e).data('product'),
        ProductName: $(e).data('productname'),
        Quality: quantity,
        CustomPrice: price,
        Image: $(e).data('image')

    };

    var store = GetCookie('ShoppingCart');
    store = AddAndUpdateShoppingCart(store, item, quantity);

    var html_item = "";
    html_item += "<div class=\"p-3 cart-block\" style=\"width: 450px !important\">";
    html_item += "<div class=\"row mx-0 mb-3\">";
    html_item += "<div class=\"col-4 p-0\" > ";
    html_item += "<img src=\"" + $(e).data('image') + "\" alt=\"\" class=\"w-100\" style=\"padding-top: 20px;\"></a>";
    html_item += " </div>";
    html_item += "<div class=\"col-8\">";
    html_item += "<h4 style=\"padding-top: 10px;\"><a href=\"#\" class=\"fables-main-text-color font-13 d-block fables-main-hover-color\">" + $(e).data('productname') + "</a></h4>";
    html_item += "<p class=\"fables-second-text-color font-weight-bold\">";
    html_item += "<span class=\"fables-iconprice\"></span>";
    html_item += "" + FormatMoney(price) + "";
    html_item += " </p>";
    html_item += "<p class=\"fables-forth-text-color\">Số lượng:" + quantity + "</p>";
    html_item += "</div>";
    html_item += "</div>";
    html_item += "</div>";
    UpdateShoppingCartView(store, 1, html_item);

}


RemoveItemFromCart = function (e) {

    var result = confirm("Bạn có chắc chắn muốn xóa sản phẩm này ?");
    if (result) {
        var item = {
            ProductID: $(e).data('product'),
            ProductName: $(e).data('productname'),
            Quality: $(e).data('quantity'),
            CustomPrice: $(e).data('price'),
            Image: $(e).data('image')

        };
        var store = GetCookie('ShoppingCart');
        store = RemoveItemFromShoppingCart(store, item);
        UpdateShoppingCartView(store, 2);

        window.location.href = utils.rootUrl() + "gio-hang";
    }


}


AddAndUpdateShoppingCart = function (store, item) {
    console.log(store);
    console.log(item);
    var index = store.findIndex(function (d) {
        return d.ProductID == item.ProductID && d.AttrID == item.AttrID;
    });
    if (store.length == 0 || index == -1) {
        store.push(item);
        SetCookie('ShoppingCart', store);
        return store;
    } else {
        store[index].Quality = parseInt(store[index].Quality) + 1;
    }
    SetCookie('ShoppingCart', store);

    alert("Thêm vào giỏ hàng thành công!")
    return store;
}

RemoveItemFromShoppingCart = function (store, item) {

    if (store.length > 0) {
        var index = store.findIndex(function (d) {
            return d.ProductID == item.ProductID;
        });

        store.splice(index, 1);
        SetCookie('ShoppingCart', store);
        return store;
    }
    //store[index].Quality = parseInt(store[index].Quality) - 1;
    //SetCookie('ShoppingCart', store);
    //return store;
}

UpdateShoppingCartView = function (store, type, html_popup) {
    if (store == undefined || store == null || store.length == 0)
        store = GetCookie('ShoppingCart');
    var countPrice = 0;
    $('.header-icons-noti').html(store.length);
    $.each(store, function (i, d) {
        countPrice += parseFloat(d.CustomPrice) * parseFloat(d.Quality)
    });
    $('.sumorder').html('Tiền hàng: ' + FormatMoney(countPrice));
    $('#Cart_totalAmount').html(FormatMoney(countPrice));
    if (type == 1) {

        // update lại danh sách sản phẩm
        //UpateListCartInHeader();
        utils.showPopup("Thêm vào giỏ hàng thành công !", 1, html_popup);
    }
}

UpateListCartInHeader = function () {
    var inputdata = {};

    $.ajax({
        type: "GET",
        url: "/CustomViews/ListCartHeaderPartial",
        data: inputdata,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (data) {
            $("#list_cart_header").html("");
            $("#list_cart_header").html(data);
        },
        error: function (data) { console.log("ShopCategory:" + JSON.stringify(data)); },
    });
}

CalcMinusorPlusQuantity = function (type, productid) {
    var $input_quantity = $("#txtQuantity_" + productid);
    var q = $("#txtQuantity_" + productid).val();

    // giảm số lượng
    if (type == 1) {
        if (parseInt(q, 10) > 1) {
            $input_quantity.val(parseInt($input_quantity.val()) - 1);
        }
    }
    // tăng số lượng
    if (type == 2) {
        $input_quantity.val(parseInt($input_quantity.val()) + 1);
    }

}


checkIsMobileDevice = function () {
    var isiPhone = navigator.userAgent.toLowerCase().indexOf("iphone");
    var isiPod = navigator.userAgent.toLowerCase().indexOf("ipod");
    var isAndroid = /android/i.test(navigator.userAgent.toLowerCase());
    var isBlackberry = navigator.userAgent.toLowerCase().indexOf("BlackBerry");
    var isOpera = /Opera/i.test(navigator.userAgent.toLowerCase());
    var isIE = navigator.userAgent.toLowerCase().indexOf("IEMobile");
    var isWinPhone = navigator.userAgent.toLowerCase().indexOf("windows phone");

    if (isiPhone > -1) return true;
    if (isiPod > -1) return true;
    if (isAndroid) return true;
    if (isBlackberry > -1) return true;
    if (isOpera) return true;
    if (isIE > -1) return true;
    if (isWinPhone > -1) return true;
    return false;
}
