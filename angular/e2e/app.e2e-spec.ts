import { DeptManageTemplatePage } from './app.po';

describe('DeptManage App', function() {
  let page: DeptManageTemplatePage;

  beforeEach(() => {
    page = new DeptManageTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
