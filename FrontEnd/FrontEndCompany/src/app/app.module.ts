import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompaniesComponent } from './components/companies/companies.component';
import { CommentsComponent } from './components/comments/comments.component';
import { DeleteCommentComponent } from './components/delete-comment/delete-comment.component';
import { AddCommentComponent } from './components/add-comment/add-comment.component';
import { UpdateCommentComponent } from './components/update-comment/update-comment.component';
import { CompanyService } from './services/company.service';
import { CommentService } from './services/comment.service';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    CompaniesComponent,
    CommentsComponent,
    DeleteCommentComponent,
    AddCommentComponent,
    UpdateCommentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'companies', component: CompaniesComponent },
      { path: 'comments', component: CommentsComponent },
      { path: 'add-comment', component: AddCommentComponent },
      { path: 'delete-comment/:id', component: DeleteCommentComponent },
      { path: 'update-comment/:id', component: UpdateCommentComponent }
    ])
  ],
  providers: [CompanyService, CommentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
