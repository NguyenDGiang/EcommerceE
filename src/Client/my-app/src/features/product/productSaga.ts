import { PayloadAction } from '@reduxjs/toolkit';
import productApi from './../../services/productApi';
import { Product } from './../../models/product';
import { call, debounce, put, takeLatest } from 'redux-saga/effects';
import { productActions } from './productSlice';

function* fetchProductList() {
  try {
    const response: Product[] = yield call(
        productApi.getAll
    );
    yield put(productActions.fetchProductListSuccess(response));
  } catch (error) {
    console.log('Failed to fetch student list', error);
    yield put(productActions.fetchProductListFailed(error instanceof Error));
  }
}

export default function* productSaga() {
    yield takeLatest(productActions.fetchProductList.type, fetchProductList);
  }
  
