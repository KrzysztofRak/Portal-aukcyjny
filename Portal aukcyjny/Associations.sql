﻿ALTER TABLE Auctions ADD CONSTRAINT fk_auctions FOREIGN KEY (OwnerId) references dbo.aspnet_Users(UserId)
ALTER TABLE Comments ADD CONSTRAINT fk_comments FOREIGN KEY (AuctionId) REFERENCES Auctions(Id)
ALTER TABLE Comments ADD CONSTRAINT fk_comments_authors FOREIGN KEY (AuthorId) REFERENCES dbo.aspnet_Users(UserId)
ALTER TABLE Bidders ADD CONSTRAINT fk_bidders FOREIGN KEY (BidderId) REFERENCES dbo.aspnet_Users(UserId)
ALTER TABLE Bidders ADD CONSTRAINT fk_bids FOREIGN KEY (AuctionId) REFERENCES Auctions(Id)
ALTER TABLE Observers ADD CONSTRAINT fk_observers FOREIGN KEY (ObserverId) REFERENCES dbo.aspnet_Users(UserId)
ALTER TABLE Observers ADD CONSTRAINT fk_watched_auctions FOREIGN KEY (AuctionId) REFERENCES Auctions(Id)