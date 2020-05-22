//The idea is to keep searching in sorted array. 
public static int SearchInPivotArray(int[] arr, int l, int h, int key)
        {
            if (l > h)
                return -1;
            int mid = l + (h - l) / 2;
            if (arr[mid] == key) return mid;
            if(arr[l]<=arr[mid])
            {
                if (key >= arr[l] && key < arr[mid])
                    SearchInPivotArray(arr, l, mid - 1, key);
                SearchInPivotArray(arr, mid + 1, h, key);
            }
            if (key >= arr[mid + 1] && key <= arr[h])
                SearchInPivotArray(arr, mid + 1, h, key);
            SearchInPivotArray(arr, l, mid - 1, key);                        
                 
        }
