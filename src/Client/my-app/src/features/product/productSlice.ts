import { RootState } from './../../app/store';
import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { Product } from './../../models/product';

export interface ProductState {
  loading?: boolean;
  products: Product[];
}

const initialState: ProductState = {
  loading: false,
  products: []
};
const productSlice = createSlice({
  name: 'product',
  initialState,
  reducers: {
    
    fetchProductList(state) {
      state.loading = true;
    },
    fetchProductListSuccess(
      state,
      action: PayloadAction<Product[]>
    ) {
      state.products = action.payload;
      state.loading = false;
    },
    fetchProductListFailed(state, action: PayloadAction<any>) {
      state.loading = false;
    }
  },
});

// Actions
export const productActions = productSlice.actions;

// Selectors
export const selectProductLoading = (state: RootState) => state.product.loading;
export const selectProductList = (state: RootState) => state.product.products;

// Reducer
const productReducer = productSlice.reducer;
export default productReducer;
