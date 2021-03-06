﻿using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MahmoudAli : IAmACommunityMember
    {
        public string FirstName => "Mahmoud";
        public string LastName => "Ali";
        public string StateOrRegion => "São Paulo, Brasil";
        public string EmailAddress => "muddibr@gmail.com";
        public string ShortBioOrTagLine => "Web and Mobile Developer";
        public Uri WebSite => new Uri("https://www.lambda3.com.br/blog");
        public string TwitterHandle => "akamud";
        public string GitHubHandle => "akamud";
        public string GravatarHash => "";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.lambda3.com.br/feed/"); } }
        public GeoPosition Position => new GeoPosition(-23.552339, -46.661393);
        public string FeedLanguageCode => "pt";
    }
}