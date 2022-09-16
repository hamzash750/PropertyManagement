import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PreviewAdsComponent } from './preview-ads.component';

describe('PreviewAdsComponent', () => {
  let component: PreviewAdsComponent;
  let fixture: ComponentFixture<PreviewAdsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PreviewAdsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PreviewAdsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
