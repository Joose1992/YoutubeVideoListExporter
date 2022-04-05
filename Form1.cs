using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Runtime.Remoting.Channels;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using Google.Apis.YouTube.v3.Data;

namespace YoutubeVideoListExporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExportVideoList_Click(object sender, EventArgs e)
        {
            GetVideos();

        }

        public void GetVideos()
        {
            try
            {
                YouTubeService yt = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "Your google api goes here!" });
                ChannelsResource.ListRequest channelsListRequest = yt.Channels.List("contentDetails");
                //channelsListRequest.ForUsername = textBox_url.Text;
                channelsListRequest.Id = textBox_url.Text;
                ChannelListResponse channelsListResponse = channelsListRequest.Execute();
                foreach (Channel channel in channelsListResponse.Items)
                {
                    string uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;
                    string nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        PlaylistItemsResource.ListRequest playlistItemsListRequest = yt.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;
                        PlaylistItemListResponse playlistItemsListResponse = playlistItemsListRequest.Execute();
                        foreach (PlaylistItem playlistItem in playlistItemsListResponse.Items)
                        {
                            dataGridView1.Rows.Add(playlistItem.Snippet.Position, playlistItem.Snippet.Title, playlistItem.Snippet.PublishedAt, playlistItem.);

                            //Console.WriteLine("Video Title= {0}, Video ID ={1}", playlistItem.Snippet.Title, playlistItem.Snippet.ResourceId.VideoId);
                        }
                        nextPageToken = playlistItemsListResponse.NextPageToken;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
               // Console.WriteLine(e.Message);
            }
        }
    }
}

