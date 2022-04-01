import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { NavComponent } from './components/shared/nav/nav.component';
import { BookstoreComponent } from './components/bookstore/bookstore.component';
import { FiltersComponent } from './components/bookstore/filters/filters.component';
import { ProductListComponent } from './components/bookstore/product-list/product-list.component';
import { ProductItemComponent } from './components/bookstore/product-list/product-item/product-item.component';
import { HttpClientModule } from '@angular/common/http';
import { BookService } from './components/bookstore/services/book.service';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    BookstoreComponent,
    FiltersComponent,
    ProductListComponent,
    ProductItemComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [BookService],
  bootstrap: [AppComponent]
})
export class AppModule { }
