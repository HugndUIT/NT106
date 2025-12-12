using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class Model
    {
        // Model cho request số trang và số lượng trang
        public class ApiRequest
        {
            [JsonProperty("current")]
            public int Current { get; set; }

            [JsonProperty("pageSize")]
            public int PageSize { get; set; }
        }

        // Model cho 1 món ăn
        public class FoodItem
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("ten_mon_an")]
            public string TenMonAn { get; set; }

            [JsonProperty("gia")]
            public string Gia { get; set; }

            [JsonProperty("hinh_anh")]
            public string HinhAnh { get; set; }

            [JsonProperty("dia_chi")]
            public string DiaChi { get; set; }

            [JsonProperty("nguoi_dong_gop")]
            public string NguoiDongGop { get; set; }

            [JsonProperty("mo_ta")]
            public string MoTa { get; set; }
        }



        // Model cho thông tin phân trang
        public class PaginationInfo
        {
            [JsonProperty("current")]
            public int Current { get; set; }

            [JsonProperty("pageSize")]
            public int PageSize { get; set; }

            [JsonProperty("total")]
            public int Total { get; set; }
        }

        // Model cho response hoàn chỉnh
        public class ApiResponse
        {
            [JsonProperty("data")]
            public List<FoodItem> Data { get; set; }

            [JsonProperty("pagination")]
            public PaginationInfo Pagination { get; set; }
        }
    }
}
