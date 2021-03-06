﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.IViews
{
    public interface IAuctionPageView
    {
        int ImageWidth { get; }
        int ImageHeight { get; }
        int AuctionId { get; set; }
        string SellerId { get; set; }
        string BestBidderId { get; set; }
        string BidderId { get; set; }
        string MinimumOffer { get; set; }
        string ObserveBtnText { get; set; }
        string ResObserve { get; }
        string ResStopObserve { get; }
        bool ObserveBtnVisiblity { get; set; }
        EventHandler ObserveBtnEvent { get; set; }
        string AuctionTitleField { get; set; }
        string AuctionImgUrl { get; set; }
        string TimeLeftField { get; set; }
        string TimeLeftLabelText { get; set; }
        string ItemsNumField { get; set; }
        bool ItemsNumLabelVisiblity { get; set; }
        bool ItemsNumFieldVisiblity { get; set; }
        string BuyItNowPriceField { get; set; }
        bool BuyItNowPriceFieldVisiblity { get; set; }
        bool BuyItNowLabelVisiblity { get; set; }
        bool BuyItNowBtnVisiblity { get; set; }
        bool CloseAuctionBtnVisiblity { get; set; }
        string HighestBidField { get; set; }
        bool HighestBidFieldVisiblity { get; set; }
        string BestBidUserNameField { get; set; }
        bool BestBidUserNameFieldVisiblity { get; set; }
        string BestBidUserNameNavUrl { get; set; }
        string BestBidLabelText { get; set; }
        bool BestBidLabelVisiblity { get; set; }
        bool BestBidUserNameLabelVisiblity { get; set; }
        string BidField { get; set; }
        bool BidFieldVisiblity { get; set; }
        bool BidBtnVisiblity { get; set; }
        string ShipmentField { get; set; }
       string SellerNameField { get; set; }
        string SellerNameNavUrl { get; set; }
        string DescriptionField { get; set; }
        string ViewsNumField { get; set; }

        void LoadOffersControls(int offersNum);
    }
}