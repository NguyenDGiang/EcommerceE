import { all, fork } from 'redux-saga/effects';
import productSaga from '../features/product/productSaga';
export default function* rootSaga() {
    yield all([
        fork(productSaga),
    ]);
}
