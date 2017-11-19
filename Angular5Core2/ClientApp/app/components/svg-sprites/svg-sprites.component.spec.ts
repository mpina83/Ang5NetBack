import {async, ComponentFixture, TestBed} from '@angular/core/testing';

import {SvgSpritesComponent} from './svg-sprites.component';

describe('SvgSpritesComponent', () => {
  let component: SvgSpritesComponent;
  let fixture: ComponentFixture<SvgSpritesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SvgSpritesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SvgSpritesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
